namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfEncryptionBoxGetInfo
    {
        [JsonProperty("encryption_box")]
        public int EncryptionBox { get; set; }
    }
}