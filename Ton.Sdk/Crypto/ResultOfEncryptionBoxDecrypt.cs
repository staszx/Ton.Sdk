namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfEncryptionBoxDecrypt
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}