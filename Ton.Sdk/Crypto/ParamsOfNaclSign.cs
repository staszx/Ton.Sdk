namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSign
    /// </summary>
    public class ParamsOfNaclSign
    {
        #region Properties

        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}