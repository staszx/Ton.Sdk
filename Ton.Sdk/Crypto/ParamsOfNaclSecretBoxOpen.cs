namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfNaclSecretBoxOpen
    {
        #region Properties

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}