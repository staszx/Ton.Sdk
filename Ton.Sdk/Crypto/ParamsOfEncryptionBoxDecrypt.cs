namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfEncryptionBoxDecrypt
    {
        [JsonProperty("encryption_box")]
        public int EncryptionBox { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}