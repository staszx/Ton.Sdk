namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class AesParams
    {
        [JsonProperty("mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CipherMode Mode { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("iv")]
        public string Iv { get; set; }
    }
}