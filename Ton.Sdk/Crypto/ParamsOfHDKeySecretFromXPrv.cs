namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of HD Key Secret From XPrv
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeySecretFromXPrv
    /// </summary>
    public class ParamsOfHDKeySecretFromXPrv
    {
        #region Properties

        /// <summary>
        /// Gets or sets the XPRV.
        /// </summary>
        /// <value>
        /// The XPRV.
        /// </value>
        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        #endregion
    }
}