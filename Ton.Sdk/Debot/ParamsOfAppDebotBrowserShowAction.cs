namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserShowAction
    {
        #region Properties

        [JsonProperty("action")]
        public DebotAction Action { get; set; }

        #endregion
    }
}