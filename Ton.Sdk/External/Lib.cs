﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ton.Sdk.Tests")]

namespace Ton.Sdk.External
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    ///     The external library import
    /// </summary>
    internal static class Lib
    {
        #region Constants

        /// <summary>
        ///     The library path
        /// </summary>
        private const string libraryPath = @".\Library\tonclient_1_win32_dll.dll";

        #endregion

        #region Methods

        /// <summary>
        /// Tcs the read string.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        [DllImport(libraryPath)]
        internal static extern tc_string_data_t tc_read_string(IntPtr text);

        /// <summary>
        /// Tcs the destroy string.
        /// </summary>
        /// <param name="text">The text.</param>
        [DllImport(libraryPath)]
        internal static extern void tc_destroy_string(IntPtr text);

        /// <summary>
        /// Tcs the create context.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        [DllImport(libraryPath)]
        internal static extern IntPtr tc_create_context(tc_string_data_t config);

        /// <summary>
        /// Tcs the destroy context.
        /// </summary>
        /// <param name="context">The context.</param>
        [DllImport(libraryPath)]
        internal static extern void tc_destroy_context(uint context);

        /// <summary>
        /// Tcs the request.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="function_name">Name of the function.</param>
        /// <param name="function_params_json">The function parameters json.</param>
        /// <param name="request_id">The request identifier.</param>
        /// <param name="response_handler">The response handler.</param>
        [DllImport(libraryPath)]
        internal static extern void tc_request(uint context, tc_string_data_t function_name, tc_string_data_t function_params_json, uint request_id, tc_response_handler_t response_handler);

        #endregion
    }
}