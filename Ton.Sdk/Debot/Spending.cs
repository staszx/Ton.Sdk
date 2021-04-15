namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class Spending
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("dst")]
        public string Dst { get; set; }
    }
}