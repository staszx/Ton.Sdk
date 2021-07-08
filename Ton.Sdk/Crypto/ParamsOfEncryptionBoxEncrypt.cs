namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfEncryptionBoxEncrypt
    {
        [JsonProperty("encryption_box")]
        public int EncryptionBox { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}