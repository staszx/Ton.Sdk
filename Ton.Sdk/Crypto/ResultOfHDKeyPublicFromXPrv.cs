namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of HD Key Public From XPrv
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfHDKeyPublicFromXPrv
    /// </summary>
    public class ResultOfHDKeyPublicFromXPrv
    {
        #region Properties

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