namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfCreateEncryptionBox
    {
        [JsonProperty("algorithm")]
        public EncryptionAlgorithm Algorithm { get; set; }
    }
}