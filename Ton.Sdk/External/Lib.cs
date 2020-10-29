using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ton.Sdk.Tests")]

namespace Ton.Sdk.External
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The external library import
    /// </summary>
    internal static class Lib
    {
        #region Constants

        /// <summary>
        /// The library path
        /// </summary>
        private const string libraryPath = @"D:\Work\Projects\TON.SDK\Ton.Sdk\Ton.Sdk\Library\tonclient_1_win32_dll.dll";

        #endregion

        #region Methods

        [DllImport(libraryPath)]
        internal static extern tc_string_data_t tc_read_string(IntPtr text);

        [DllImport(libraryPath)]
        internal static extern void tc_destroy_string(string text);

        [DllImport(libraryPath)]
        internal static extern IntPtr tc_create_context(tc_string_data_t config);

        [DllImport(libraryPath)]
        internal static extern void tc_destroy_context(IntPtr context);

        [DllImport(libraryPath)]
        internal static extern void tc_request(uint context, tc_string_data_t function_name, tc_string_data_t function_params_json, uint request_id, tc_response_handler_t response_handler);

        public static void libraryResponseHandler(uint requestId, tc_string_data_t paramJson, uint responseType, bool finished)
        {
            //const request = requests.get(requestId);
            //if (!request)
            //{
            //    return;
            //}
            //if (finished)
            //{
            //    requests.delete(requestId);
            //}
            //var param = paramJson != "" ? JSON.parse(paramsJson) : undefined;
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

        internal static void RequestLibrary(uint context, tc_string_data_t functionName, tc_string_data_t functionParams, tc_response_handler_t responseHandler)
        {
            tc_request(context, functionName, functionParams, 0, libraryResponseHandler);
        }

        internal static void getVersion(uint context)
        {
            tc_string_data_t functionName = new tc_string_data_t();
            functionName.Value = "client.version";

            tc_string_data_t functionParams = new tc_string_data_t();
            functionParams.Value = "";
            
            RequestLibrary(context, functionName , functionParams, null);
        }
    #endregion
}
}