namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class EncryptionAlgorithm
    {
        [JsonProperty("type")]
        public string Type { get; set; } = "AES";

        [JsonProperty("AesParams ")]
        public AesParams AesParams { get; set; }
    }
}