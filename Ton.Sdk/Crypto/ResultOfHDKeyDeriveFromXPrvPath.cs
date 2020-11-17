namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of HD Key Derive From XPrv Path
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfHDKeyDeriveFromXPrvPath
    /// </summary>
    public class ResultOfHDKeyDeriveFromXPrvPath
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        #endregion
    }
}