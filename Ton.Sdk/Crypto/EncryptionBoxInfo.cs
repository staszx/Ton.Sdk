namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class EncryptionBoxInfo
    {
        [JsonProperty("hdpath")]
        public string Hdpath { get; set; }

        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("options")]
        public object Options { get; set; }

        [JsonProperty("public")]
        public object Public { get; set; }
    }
}