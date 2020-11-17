namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params of Factorize
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfFactorize
    /// </summary>
    public class ParamsOfFactorize
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the composite.
        /// </summary>
        /// ParamsOfFactorize
        /// <value>
        ///     The composite.
        /// </value>
        [JsonProperty("composite")]
        public string Composite { get; set; }

        #endregion
    }
}