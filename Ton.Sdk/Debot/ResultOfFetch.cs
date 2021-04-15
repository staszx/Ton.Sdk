namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ResultOfFetch
    {
        [JsonProperty("info")]
        public DebotInfo Info { get; set; }
    }
}