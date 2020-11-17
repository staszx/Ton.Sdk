namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Factorize
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfFactorize
    /// </summary>
    public class ResultOfFactorize
    {
        #region Properties

        /// <summary>
        /// Gets or sets the factors.
        /// </summary>
        /// <value>
        /// The factors.
        /// </value>
        [JsonProperty("factors")]
        public string[] Factors { get; set; }

        #endregion
    }
}