﻿//-----------------------------------------------------------------------------------------------------------
// <copyright file="Types.cs" company="Aspose Pty Ltd" author="" date="12.11.2020 15:42:45">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Ton.Sdk.External
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    ///     The external lib string structure
    /// </summary>
    // [StructLayout(LayoutKind.Sequential)]
    public struct tc_string_data_t
    {
        /// <summary>
        ///     The content
        /// </summary>
        public IntPtr content;

        /// <summary>
        ///     The length
        /// </summary>
        public int len;

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        public string Value
        {
            get => Marshal.PtrToStringUTF8(this.content, this.len);
            set
            {
                var utf8 = Encoding.UTF8;
                this.len = utf8.GetByteCount(value);
                this.content = Marshal.StringToCoTaskMemUTF8(value);
            }
        }

        /// <summary>
        ///     Converts to string.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <autogeneratedoc />
        public override string ToString()
        {
            return this.Value;
        }

        private static string Utf8ToAscii(string text)
        {
            var utf8 = Encoding.UTF8;
            var encodedBytes = utf8.GetBytes(text);
            var convertedBytes = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, encodedBytes);
            var ascii = Encoding.ASCII;
            return ascii.GetString(convertedBytes);
        }
    }

    /// <summary>
    ///     The respone handler
    /// </summary>
    /// <param name="request_id">The request identifier.</param>
    /// <param name="params_json">The parameters json.</param>
    /// <param name="response_type">Type of the response.</param>
    /// <param name="finished">if set to <c>true</c> [finished].</param>
    internal delegate void tc_response_handler_t(uint request_id, tc_string_data_t params_json, uint response_type, bool finished);
}