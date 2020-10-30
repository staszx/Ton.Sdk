namespace Ton.Sdk.Request
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using External;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The request library
    /// </summary>
    internal sealed class RequestLib : IDisposable
    {
        /// <summary>
        ///     The timeout
        /// </summary>
        private const int Timeout = 5000;

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

        /// <summary>
        ///     Initializes a new instance of the <see cref="RequestLib" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public RequestLib(string config)
        {
            this.context = GetContext(config);
        }

        /// <summary>
        ///     Libraries the response handler.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="paramJson">The parameter json.</param>
        /// <param name="responseType">Type of the response.</param>
        /// <param name="finished">if set to <c>true</c> [finished].</param>
        public void LibraryResponseHandler(uint requestId, tc_string_data_t paramJson, uint responseType, bool finished)
        {
            var response = new Response(requestId);
            response.ResponseType = (ResponseTypes) responseType;
            response.ReturnValue = paramJson.Value;
            this.AddResponse(response);

            //if (finished)
            //{

            //}

            //var param = paramJson.Value != "" ? JSON.parse(paramsJson) : undefined;
            //switch (responseType)
            //{
            //    case 0: // RESULT
            //        request.resolve(param);
            //        break;
            //    case 1: // ERROR
            //        request.reject(params);
            //        break;
            //    default: // DATA
            //        if (responseType >= 100 && request.responseHandler)
            //        {
            //            request.responseHandler(param);
            //        }
            //        break;
            //}
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
                return this.responses.FirstOrDefault(r => r.RequestId == requestId);
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
                Console.WriteLine(this.responses.Count);
            }
        }

        /// <summary>
        ///     Gets the context.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static uint GetContext(string config)
        {
            var cfg = new tc_string_data_t {Value = config};
            var jsonPtr = Lib.tc_create_context(cfg);
            var json = Lib.tc_read_string(jsonPtr);
            var value = JObject.Parse(json.Value)["result"].Value<uint>();
            //Lib.tc_destroy_string(jsonPtr);
            return value;
        }

        /// <summary>
        ///     Requests the library.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="functionParams">The function parameters.</param>
        /// <returns></returns>
        internal async Task<JObject> RequestLibrary(string functionName, string functionParams)
        {
            return await Task<JObject>.Factory.StartNew(() =>
            {
                var requestId = this.NextIndex();
                var fName = new tc_string_data_t {Value = functionName};
                var fParams = new tc_string_data_t {Value = functionParams};

                Lib.tc_request(this.context, fName, fParams, requestId, this.LibraryResponseHandler);

                var time = DateTime.Now.Millisecond;
                var response = this.GetResponse(requestId);
                while (response == null && DateTime.Now.Millisecond - time < Timeout)
                {
                    response = this.GetResponse(requestId);
                }

                if (response == null)
                {
                    throw new TimeoutException(string.Format("Time out of respone, function name = {0}", functionName));
                }

                this.RemoveResponse(response);
                
                switch (response.ResponseType)
                {
                    case ResponseTypes.Success:
                        return JObject.Parse(response.ReturnValue);
                    case ResponseTypes.Error:
                        throw new Exception(response.ReturnValue);
                    //case ResponseTypes.Nop:
                    //    break;
                    //case ResponseTypes.Custom:
                    //    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Lib.tc_destroy_context(this.context);
        }
    }
}