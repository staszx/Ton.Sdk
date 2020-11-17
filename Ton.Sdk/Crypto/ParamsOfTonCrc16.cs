namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Ton Crc16
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfTonCrc16
    /// </summary>
    public class ParamsOfTonCrc16
    {
        #region Properties

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonProperty("data")]
        public string Data { get; set; }

        #endregion
    }
}