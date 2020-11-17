namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfSign
    /// </summary>
    public class ParamsOfSign
    {
        #region Properties

        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        [JsonProperty("keys")]
        public KeyPair Keys { get; set; }

        #endregion
    }
}