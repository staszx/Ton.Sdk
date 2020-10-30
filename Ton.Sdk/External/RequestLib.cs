using System;
using System.Collections.Generic;
using System.Text;

namespace Ton.Sdk.External
{
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    internal class RequestLib
    {
        //List<Request> requests = new List<Request>();
        //List<Request> finishedRequests = new List<Request>();

        private uint requestIndex;
        object sync = new object();

        public  void libraryResponseHandler(uint requestId, tc_string_data_t paramJson, uint responseType, bool finished)
        {

            Request request = null;
            lock (this.sync)
            { 
                request = this.requests.FirstOrDefault(r => r.RequestId == requestId);
            }

            if (request == null)
            {
                return;
            }

            if (finished)
            {
                lock (this.sync)
                {
                    requests.Remove(request);
                    finished.
                }
            }

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
        /// Nexts the index.
        /// </summary>
        /// <returns></returns>
        private uint NextIndex()
        {
            lock (sync)
            {
                return this.requestIndex++;
            }
        }

        internal  void RequestLibrary(uint context, tc_string_data_t functionName, tc_string_data_t functionParams, tc_response_handler_t responseHandler)
        {
            Task.Factory.StartNew(() =>
            {

                Request request = new Request(this.NextIndex());
                Lib.tc_request(context, functionName, functionParams, request.Id, libraryResponseHandler);
            });

        }
    }
}
