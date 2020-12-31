//Changes: https://github.com/tonlabs/TON-SDK/blob/master/CHANGELOG.md
namespace Ton.Sdk.Request
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Client;
    using Exceptions;
    using External;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The request library
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/json_interface.md
    /// </summary>
    internal sealed class RequestLib : IDisposable
    {
        #region Constants

        /// <summary>
        ///     The timeout
        /// </summary>
        private const uint Timeout = 5000;

        #endregion

        #region Fields

        /// <summary>
        ///     The context
        /// </summary>
        private readonly uint context;

        /// <summary>
        /// The request time out
        /// </summary>
        private readonly uint requestTimeOut = Timeout;

        /// <summary>
        ///     The responses
        /// </summary>
        private readonly List<Response> responses = new List<Response>();

        /// <summary>
        ///     The synchronize responses
        /// </summary>
        private readonly object syncResponses = new object();

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RequestLib" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public RequestLib(ClientConfig config)
        {
            this.requestTimeOut = config.Network?.WaitForTimeout ?? Timeout;
            var sConfig = SeralizeObject(config);
            this.context = GetContext(sConfig);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Libraries the response handler.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="paramJson">The parameter json.</param>
        /// <param name="responseType">Type of the response.</param>
        /// <param name="finished">if set to <c>true</c> [finished].</param>
        public void  LibraryResponseHandler(uint requestId, tc_string_data_t paramJson, uint responseType, bool finished)
        {
            Response response;
            if (responseType >= 100)
            {
                response = this.GetResponse(requestId, true);
                response?.ResponseHandler?.Invoke(paramJson.Value, (ResponseTypes) responseType);
                return;
            }
            else if ((ResponseTypes)responseType == ResponseTypes.ResponseAppRequest)
            {
                try
                {
                    var p = new ParamsOfResolveAppRequest()
                    {
                        AppRequestId = requestId,
                        Result = new AppRequestResult() { Type = "ok", Result = paramJson.Value }

                    };

                    this.ResolveAppRequest(SeralizeObject(p)).Wait();
                }
                catch (Exception e)
                {
                    var p = new ParamsOfResolveAppRequest()
                    {
                        AppRequestId = requestId,
                        Result = new AppRequestResult() { Type = "error", Text = e.Message }

                    };

                    this.ResolveAppRequest(SeralizeObject(p)).Wait();
                }
            }


            response = this.GetRequest(requestId);
            if (response == null)
            {
                return;
            }

            response.ReturnValue = paramJson.Value;
            response.Finished = finished;
            response.ResponseType = (ResponseTypes) responseType;
        }

        /// <summary>
        ///     Gets the context.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static uint GetContext(string config)
        {
            var cfg = new tc_string_data_t
            {
                Value = config
            };
            var jsonPtr = Lib.TcCreateContext(cfg);
            var json = Lib.TcReadString(jsonPtr);
            var value = JObject.Parse(json.Value)["result"].Value<uint>();
            Lib.TcDestroyString(jsonPtr);
            return value;
        }

        /// <summary>
        ///     Requests the library.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="functionParams">The function parameters.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns></returns>
        internal async Task<T> Request<T>(string functionName, object functionParams = null, ResponseHandler responseHandler = null)
        {
            return await Task<T>.Factory.StartNew(() =>
            {
                var requestId = this.NextIndex();
                var param = functionParams == null ? "" : SeralizeObject(functionParams);
                var fName = new tc_string_data_t
                {
                    Value = functionName
                };
                var fParams = new tc_string_data_t
                {
                    Value = param
                };
                var request = new Response(requestId, responseHandler);
                this.AddResponse(request);

                Lib.TcRequest(this.context, fName, fParams, requestId, this.LibraryResponseHandler);

                var time = DateTime.Now;
                var response = this.GetResponse(requestId);
                while (response == null && (DateTime.Now - time).TotalMilliseconds < this.requestTimeOut)
                {
                    response = this.GetResponse(requestId);
                    Thread.Sleep(100);
                }

                if (response == null)
                {
                    throw new TimeoutException(string.Format("Time out of request, function name = {0}", functionName));
                }

                if (response.Finished)
                {
                    this.RemoveResponse(response);
                }

                switch (response.ResponseType)
                {
                    case ResponseTypes.Success:
                        if (response.ReturnValue == null)
                        {
                            return default;
                        }

                        return DeserializeObject<T>(response.ReturnValue);
                    case ResponseTypes.Error:
                        var error = DeserializeObject<ClientError>(response.ReturnValue);
                        throw new TonClientInternalException(string.Format("Inner exception:\nCode:{0}, Message:{1}", error.Code, error.Message));
                    default:
                        var handlerMsg = responseHandler == null ? "is null" : "is not null";
                        throw new UnknownResponseTypeException(string.Format("ResponseType = {0} & ResponseHandler {1}", response.ResponseType
                            , handlerMsg));
                }
            });
        }

        /// <summary>
        ///     Seralizes the object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        private static string SeralizeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        /// <summary>
        ///     Deserializes the object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        private static T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        /// <summary>
        ///     Nexts the index.
        /// </summary>
        /// <returns></returns>
        private uint NextIndex()
        {
            lock (this.syncResponses)
            {
                if (this.responses.Count == 0)
                {
                    return 0;
                }

                return this.responses.Max(r => r.RequestId) + 1;
            }
        }

        /// <summary>
        ///     Removes the specified response.
        /// </summary>
        /// <param name="response">The response.</param>
        private void RemoveResponse(Response response)
        {
            lock (this.syncResponses)
            {
                this.responses.Remove(response);
            }
        }

        /// <summary>
        ///     Gets the response.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="anyType">if set to <c>true</c> [any type].</param>
        /// <returns></returns>
        private Response GetResponse(uint requestId, bool anyType = false)
        {
            lock (this.syncResponses)
            {
                if (anyType)
                {
                    return this.responses.FirstOrDefault(r => r.RequestId == requestId);
                }

                return this.responses.FirstOrDefault(r => r.RequestId == requestId && r.ResponseType != ResponseTypes.None);
            }
        }

        public async Task ResolveAppRequest(string par)
        {
            await this.Request<object>("client.resolve_app_request", par);
        }

        /// <summary>
        ///     Gets the response.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns></returns>
        private Response GetRequest(uint requestId)
        {
            lock (this.syncResponses)
            {
                return this.responses.FirstOrDefault(r => r.RequestId == requestId && r.ResponseType == ResponseTypes.None);
            }
        }

        /// <summary>
        ///     Adds the response.
        /// </summary>
        /// <param name="response">The response.</param>
        private void AddResponse(Response response)
        {
            lock (this.syncResponses)
            {
                this.responses.Add(response);
            }
        }

        #endregion

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Lib.TcDestroyContext(this.context);
        }
    }

    /// <summary>
    /// </summary>
    /// <param name="param">The parameter.</param>
    //public delegate string ResponseHandler (string param);
    public delegate void ResponseHandler(string param, ResponseTypes type);
}