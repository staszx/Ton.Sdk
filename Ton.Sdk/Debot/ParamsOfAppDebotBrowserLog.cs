namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserLog
    {
        #region Properties

        [JsonProperty("msg")]
        public string Msg { get; set; }

        #endregion
    }
}