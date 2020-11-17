namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of HD Key Derive From XPrv
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfHDKeyDeriveFromXPrv
    /// </summary>
    public class ResultOfHDKeyDeriveFromXPrv
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        #endregion
    }
}