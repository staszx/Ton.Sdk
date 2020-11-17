namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of HD Key Secret From XPrv
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfHDKeySecretFromXPrv
    /// </summary>
    public class ResultOfHDKeySecretFromXPrv
    {
        #region Properties

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}