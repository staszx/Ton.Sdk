namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserInput
    {
        #region Properties

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        #endregion
    }
}