namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class AesInfo
    {
        [JsonProperty("mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CipherMode Mode { get; set; }

        [JsonProperty("iv")]
        public string Iv { get; set; }
    }
}