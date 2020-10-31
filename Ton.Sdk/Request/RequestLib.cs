namespace Ton.Sdk.Request
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Client;
    using Exceptions;
    using External;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Utils;

    /// <summary>
    ///     The request library
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
        ///     The responses
        /// </summary>
        private readonly List<Response> responses = new List<Response>();

        /// <summary>
        ///     The synchronize responses
        /// </summary>
        private readonly object syncResponses = new object();

        private uint requestTimeOut = Timeout;

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
        public void LibraryResponseHandler(uint requestId, tc_string_data_t paramJson, uint responseType, bool finished)
        {
            Response response = this.GetRequest(requestId);
            response.ResponseType = (ResponseTypes)responseType;
            response.ReturnValue = paramJson.Value;
            this.AddResponse(response);
            if (finished)
            {
                this.RemoveResponse(response);
            }
        }

        /// <summary>
        ///     Gets the context.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static uint GetContext(string config)
        {
            tc_string_data_t cfg = new tc_string_data_t { Value = config };
            IntPtr jsonPtr = Lib.tc_create_context(cfg);
            tc_string_data_t json = Lib.tc_read_string(jsonPtr);
            uint value = JObject.Parse(json.Value)["result"].Value<uint>();
            //Lib.tc_destroy_string(jsonPtr);
            return value;
        }

        /// <summary>
        /// Requests the library.
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
                uint requestId = this.NextIndex();
                var param = functionParams == null ? "" : SeralizeObject(functionParams);
                tc_string_data_t fName = new tc_string_data_t { Value = functionName };
                tc_string_data_t fParams = new tc_string_data_t { Value = param };
                Response request = new Response(requestId, responseHandler);
                this.AddResponse(request);

                Lib.tc_request(this.context, fName, fParams, requestId, this.LibraryResponseHandler);

                int time = DateTime.Now.Millisecond;
                Response response = this.GetResponse(requestId);
                while (response == null && DateTime.Now.Millisecond - time < this.requestTimeOut)
                {
                    response = this.GetResponse(requestId);
                }

                if (response == null)
                {
                    throw new TimeoutException(string.Format("Time out of request, function name = {0}", functionName));
                }

                switch (response.ResponseType)
                {
                    case ResponseTypes.Success:
                        return JsonConvert.DeserializeObject<T>(response.ReturnValue);
                    case ResponseTypes.Error:
                        var error = JsonConvert.DeserializeObject<ClientError>(response.ReturnValue);
                        throw new TonClientInternalException(string.Format("Inner exception:\nCode:{0}, Message:{1}", error.Code, error.Message));
                    default:
                        if ((int) response.ResponseType >= 100 && response.ResponseHandler != null)
                        {
                            return JsonConvert.DeserializeObject<T> (request.ResponseHandler(param));
                        }

                        var handlerMsg = responseHandler == null ? "is null" : "is not null";
                        throw new UnknownResponseTypeException(string.Format("ResponseType = {0} & ResponseHandler {1}", response.ResponseType, handlerMsg));

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
        /// <returns></returns>
        private Response GetResponse(uint requestId)
        {
            lock (this.syncResponses)
            {
                return this.responses.FirstOrDefault(r => r.RequestId == requestId && r.ResponseType!=ResponseTypes.None);
            }
        }

        /// <summary>
        /// Gets the response.
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
            Lib.tc_destroy_context(this.context);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="param">The parameter.</param>
    /// <returns></returns>
    public delegate string ResponseHandler (string param);
}