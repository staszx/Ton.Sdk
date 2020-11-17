namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfSign
    /// </summary>
    public class ParamsOfSign
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unsigned.
        /// </summary>
        /// <value>
        /// The unsigned.
        /// </value>
        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        [JsonProperty("keys")]
        public KeyPair Keys { get; set; }

        #endregion
    }
}