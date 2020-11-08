namespace Ton.Sdk.Tests
{
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The test helpers
    /// </summary>
    public static class Helpers
    {
        #region Methods

        /// <summary>
        ///     Base64s the encode.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <returns></returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        ///     Base64s the encode.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns></returns>
        public static string Base64Encode(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        ///     Base64s the decode.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string Base64Decode(string text)
        {
            var bytes = Convert.FromBase64String(text);
            return Encoding.ASCII.GetString(bytes);
        }

        /// <summary>
        ///     Strings to byte array.
        /// </summary>
        /// <param name="hex">The hexadecimal.</param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
        }

        #endregion
    }
}