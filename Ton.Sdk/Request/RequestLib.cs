namespace Ton.Sdk.Request
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
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


        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RequestLib" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public RequestLib(ClientConfig config)
        {
            var sConfig = SeralizeObject(config);
            this.context = GetContext(sConfig);
        }

        #endregion

        #region Methods

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
            var jsonPtr = Lib.tc_create_context(cfg);
            var json = Lib.tc_read_string(jsonPtr);
            var value = JObject.Parse(json.Value)["result"].Value<uint>();
            Lib.tc_destroy_string(jsonPtr);
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
            var param = functionParams == null ? "" : SeralizeObject(functionParams);
            var fName = new tc_string_data_t
            {
                Value = functionName
            };

            var fParams = new tc_string_data_t
            {
                Value = param
            };

            var taskCompletionSource = new TaskCompletionSource<T>();

            Lib.tc_request(this.context, fName, fParams, 1, (requestId, paramJson, responseType, finished) =>
            {
                switch ((ResponseTypes) responseType)
                {
                    case ResponseTypes.Success:
                        taskCompletionSource.SetResult(DeserializeObject<T>(paramJson.Value));
                        break;
                    case ResponseTypes.Error:
                        var error = DeserializeObject<ClientError>(paramJson.Value);
                        taskCompletionSource.SetException(new TonClientInternalException(string.Format("Inner exception:\nCode:{0}, Message:{1}",
                            error.Code, error.Message)));
                        break;
                    case ResponseTypes.Nop:
                        break;
                    default:
                        if (responseHandler != null && responseType >= 100)
                        {
                            responseHandler.Invoke(paramJson.Value, (ResponseTypes) responseType);
                            taskCompletionSource.SetResult(default);
                        }
                        else
                        {
                            throw new UnknownResponseTypeException(string.Format("ResponseType = {0} & ResponseHandler {1}", responseType,
                                responseHandler));
                        }

                        break;
                }
            });


            return await taskCompletionSource.Task;
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
    /// </summary>
    /// <param name="param">The parameter.</param>
    //public delegate string ResponseHandler (string param);
    public delegate void ResponseHandler(string param, ResponseTypes type);
}