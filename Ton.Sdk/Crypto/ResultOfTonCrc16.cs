namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Ton Crc16
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfTonCrc16
    /// </summary>
    public class ResultOfTonCrc16
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CRC.
        /// </summary>
        /// <value>
        /// The CRC.
        /// </value>
        [JsonProperty("crc")]
        public uint Crc { get; set; }

        #endregion
    }
}