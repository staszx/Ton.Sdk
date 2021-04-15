namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ParamsOfDecompressZstd
    {
        [JsonProperty("compressed")]
        public string Compressed { get; set; }
    }
}