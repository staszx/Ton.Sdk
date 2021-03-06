namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of HD Key XPrv From Mnemonic
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfHDKeyXPrvFromMnemonic
    /// </summary>
    public class ResultOfHDKeyXPrvFromMnemonic
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