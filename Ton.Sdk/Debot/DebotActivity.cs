namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class DebotActivity
    {
        [JsonProperty("type")]
        public string DebotActivityType { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("dst")]
        public string Dst { get; set; }

        [JsonProperty("out")]
        public Spending[] Out { get; set; }

        [JsonProperty("fee")]
        public long Fee { get; set; }

        [JsonProperty("setcode")]
        public bool Setcode { get; set; }

        [JsonProperty("signkey")]
        public string Signkey { get; set; }
    }
}