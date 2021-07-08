namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfEncryptionBoxEncrypt
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}