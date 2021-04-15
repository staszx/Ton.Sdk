namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfInit
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}