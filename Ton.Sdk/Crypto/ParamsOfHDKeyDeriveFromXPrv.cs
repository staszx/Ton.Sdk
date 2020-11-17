namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of HD Key Derive From XPrv
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyDeriveFromXPrv
    /// </summary>
    public class ParamsOfHDKeyDeriveFromXPrv
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the XPRV.
        /// </summary>
        /// <value>
        ///     The XPRV.
        /// </value>
        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        /// <summary>
        ///     Gets or sets the index of the child.
        /// </summary>
        /// <value>
        ///     The index of the child.
        /// </value>
        [JsonProperty("child_index")]
        public int ChildIndex { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="ParamsOfHDKeyDeriveFromXPrv" /> is hardened.
        /// </summary>
        /// <value>
        ///     <c>true</c> if hardened; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("hardened")]
        public bool Hardened { get; set; }

        #endregion
    }
}