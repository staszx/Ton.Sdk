using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ton.Sdk.Tests")]

namespace Ton.Sdk.External
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    ///     The external library import
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/json_interface.md
    /// </summary>
    internal static class Lib
    {
        #region Constructors

        static Lib()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                TcReadString = LibMac.tc_read_string;
                TcDestroyString = LibMac.tc_destroy_string;
                TcCreateContext = LibMac.tc_create_context;
                TcDestroyContext = LibMac.tc_destroy_context;
                TcRequest = LibMac.tc_request;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                TcReadString = LibLinux.tc_read_string;
                TcDestroyString = LibLinux.tc_destroy_string;
                TcCreateContext = LibLinux.tc_create_context;
                TcDestroyContext = LibLinux.tc_destroy_context;
                TcRequest = LibLinux.tc_request;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                TcReadString = LibWindows.tc_read_string;
                TcDestroyString = LibWindows.tc_destroy_string;
                TcCreateContext = LibWindows.tc_create_context;
                TcDestroyContext = LibWindows.tc_destroy_context;
                TcRequest = LibWindows.tc_request;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the tc string data t.
        /// </summary>
        /// <value>
        ///     The tc string data t.
        /// </value>
        internal static ReadString TcReadString { get; }

        /// <summary>
        ///     Tcs the destroy string.
        /// </summary>
        /// <value>
        ///     The tc destroy string.
        /// </value>
        internal static DestroyString TcDestroyString { get; }

        /// <summary>
        ///     Gets the tc create context.
        /// </summary>
        /// <value>
        ///     The tc create context.
        /// </value>
        internal static CreateContext TcCreateContext { get; }


        /// <summary>
        /// Gets the tc destroy context.
        /// </summary>
        /// <value>
        /// The tc destroy context.
        /// </value>
        internal static DestroyContext TcDestroyContext { get; }


        /// <summary>
        ///     Gets or sets the tc request.
        /// </summary>
        /// <value>
        ///     The tc request.
        /// </value>
        internal static RequestDlg TcRequest { get; }

        #endregion

        internal delegate tc_string_data_t ReadString(IntPtr text);

        internal delegate void DestroyString(IntPtr text);

        internal delegate IntPtr CreateContext(tc_string_data_t config);

        internal delegate void DestroyContext(uint context);

        internal delegate void RequestDlg(uint context, tc_string_data_t functionName, tc_string_data_t functionParamsJson, uint requestId,
            tc_response_handler_t responseHandler);
    }
}