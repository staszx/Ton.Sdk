namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class RegisteredEncryptionBox
    {
        [JsonProperty("handle")]
        public int Handle { get; set; }
    }
}