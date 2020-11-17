namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfSign
    /// </summary>
    public class ResultOfSign
    {
        #region Properties

        /// <summary>
        /// Gets or sets the signed.
        /// </summary>
        /// <value>
        /// The signed.
        /// </value>
        [JsonProperty("signed")]
        public string Signed { get; set; }

        /// <summary>
        /// Gets or sets the signature.
        /// </summary>
        /// <value>
        /// The signature.
        /// </value>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        #endregion
    }
}