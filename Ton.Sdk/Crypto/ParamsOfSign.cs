namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

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