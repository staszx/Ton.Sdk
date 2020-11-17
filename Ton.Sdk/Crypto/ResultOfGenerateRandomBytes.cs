namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Generate Random Bytes
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfGenerateRandomBytes
    /// </summary>
    public class ResultOfGenerateRandomBytes
    {
        #region Properties

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        [JsonProperty("bytes")]
        public string Bytes { get; set; }

        #endregion
    }
}