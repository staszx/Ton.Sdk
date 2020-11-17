namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of HD Key Public From XPrv
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyPublicFromXPrv
    /// </summary>
    public class ParamsOfHDKeyPublicFromXPrv
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        #endregion
    }
}