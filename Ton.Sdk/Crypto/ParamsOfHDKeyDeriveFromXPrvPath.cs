namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of HD Key Derive From XPrv Path
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyDeriveFromXPrvPath
    /// </summary>
    public class ParamsOfHDKeyDeriveFromXPrvPath
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        #endregion
    }
}