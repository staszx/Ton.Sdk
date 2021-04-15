namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class RegisteredDebot
    {
        #region Properties

        [JsonProperty("debot_handle")]
        public int DebotHandle { get; set; }

        [JsonProperty("debot_abi")]
        public string DebotAbi { get; set; }

        [JsonProperty("info")]
        public DebotInfo Info { get; set; }

        #endregion
    }
}