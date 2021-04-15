namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ResultOfCompressZstd
    {
        [JsonProperty("compressed")]
        public string Compressed { get; set; }
    }
}