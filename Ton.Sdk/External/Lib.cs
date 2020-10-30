using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ton.Sdk.Tests")]

namespace Ton.Sdk.External
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

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

        private static List<Request> requests = new List<Request>();

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