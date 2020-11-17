namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Verify Signature
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfVerifySignature
    /// </summary>
    public class ResultOfVerifySignature
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

        #endregion
    }
}