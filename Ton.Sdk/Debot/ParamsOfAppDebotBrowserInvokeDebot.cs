namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserInvokeDebot
    {
        #region Properties

        [JsonProperty("debot_addr")]
        public string DebotAddr { get; set; }

        [JsonProperty("action")]
        public DebotAction Action { get; set; }

        #endregion
    }
}