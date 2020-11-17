namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of HD Key Derive From XPrv Path
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyDeriveFromXPrvPath
    /// </summary>
    public class ParamsOfHDKeyDeriveFromXPrvPath
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

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonProperty("path")] 
        public string Path { get; set; }

        #endregion
    }
}