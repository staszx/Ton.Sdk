namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class DebotInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("support")]
        public string Support { get; set; }

        [JsonProperty("hello")]
        public string Hello { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("dabi")]
        public string Dabi { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("interfaces")]
        public string[] Interfaces { get; set; }
    }
}