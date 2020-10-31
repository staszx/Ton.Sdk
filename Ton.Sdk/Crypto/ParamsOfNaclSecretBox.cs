namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfNaclSecretBox
    {
        #region Properties

        [JsonProperty("decrypted")]
        public string Decrypted { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}