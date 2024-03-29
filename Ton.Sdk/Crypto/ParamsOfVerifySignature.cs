namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Verify Signature
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfVerifySignature
    /// </summary>
    public class ParamsOfVerifySignature
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
        /// Gets or sets the public.
        /// </summary>
        /// <value>
        /// The public.
        /// </value>
        [JsonProperty("public")]
        public string Public { get; set; }

        #endregion
    }
}