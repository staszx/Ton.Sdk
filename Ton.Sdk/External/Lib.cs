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
        #region Methods

        /// <summary>
        ///     Gets the operating system.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Cannot determine operating system!</exception>
        public static PlatformID GetOperatingSystem()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return PlatformID.MacOSX;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return PlatformID.Unix;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return PlatformID.Win32NT;
            }

            throw new Exception("Cannot determine operating system!");
        }

        /// <summary>
        ///     Tcs the read string.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        internal static tc_string_data_t tc_read_string(IntPtr text)
        {
            var platform = GetOperatingSystem();
            switch (platform)
            {
                case PlatformID.MacOSX:
                    return LibMac.tc_read_string(text);
                case PlatformID.Unix:
                    return LibLinux.tc_read_string(text);
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    return LibWindows.tc_read_string(text);
                default:
                    throw new NotSupportedException("OS not supported!");
            }
        }

        /// <summary>
        ///     Tcs the destroy string.
        /// </summary>
        /// <param name="text">The text.</param>
        internal static void tc_destroy_string(IntPtr text)
        {
            var platform = GetOperatingSystem();
            switch (platform)
            {
                case PlatformID.MacOSX:
                    LibMac.tc_destroy_string(text);
                    return;
                case PlatformID.Unix:
                    LibLinux.tc_destroy_string(text);
                    return;
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    LibWindows.tc_destroy_string(text);
                    return;
                default:
                    throw new NotSupportedException("OS not supported!");
            }
        }

        /// <summary>
        ///     Tcs the create context.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        internal static IntPtr tc_create_context(tc_string_data_t config)
        {
            var platform = GetOperatingSystem();
            switch (platform)
            {
                case PlatformID.MacOSX:
                    return LibMac.tc_create_context(config);
                case PlatformID.Unix:
                    return LibLinux.tc_create_context(config);
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    return LibWindows.tc_create_context(config);
                default:
                    throw new NotSupportedException("OS not supported!");
            }
        }

        /// <summary>
        ///     Tcs the destroy context.
        /// </summary>
        /// <param name="context">The context.</param>
        internal static void tc_destroy_context(uint context)
        {
            var platform = GetOperatingSystem();
            switch (platform)
            {
                case PlatformID.MacOSX:
                    LibMac.tc_destroy_context(context);
                    return;
                case PlatformID.Unix:
                    LibLinux.tc_destroy_context(context);
                    return;
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                   // LibWindows.tc_destroy_context(context);
                    return;
                default:
                    throw new NotSupportedException("OS not supported!");
            }
        }

        /// <summary>
        ///     Tcs the request.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="function_name">Name of the function.</param>
        /// <param name="function_params_json">The function parameters json.</param>
        /// <param name="request_id">The request identifier.</param>
        /// <param name="response_handler">The response handler.</param>
        internal static void tc_request(uint context, tc_string_data_t function_name, tc_string_data_t function_params_json, uint request_id,
            tc_response_handler_t response_handler)
        {
            var platform = GetOperatingSystem();
            switch (platform)
            {
                case PlatformID.MacOSX:
                    LibMac.tc_request(context, function_name, function_params_json, request_id, response_handler);
                    return;
                case PlatformID.Unix:
                    LibLinux.tc_request(context, function_name, function_params_json, request_id, response_handler);
                    return;
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    LibWindows.tc_request(context, function_name, function_params_json, request_id, response_handler);
                    return;
                default:
                    throw new NotSupportedException("OS not supported!");
            }
        }

        #endregion
    }
}