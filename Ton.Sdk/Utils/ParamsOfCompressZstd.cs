namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ParamsOfCompressZstd
    {
        [JsonProperty("uncompressed")]
        public string Uncompressed { get; set; }

        [JsonProperty("level")]
        public uint? Level { get; set; }
    }
}