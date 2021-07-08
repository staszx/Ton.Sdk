namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfEncryptionBoxGetInfo
    {
        [JsonProperty("info")]
        public EncryptionBoxInfo Info { get; set; }
    }
}