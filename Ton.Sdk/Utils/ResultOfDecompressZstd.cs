namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ResultOfDecompressZstd
    {
        [JsonProperty("decompressed")]
        public string Decompressed { get; set; }
    }
}