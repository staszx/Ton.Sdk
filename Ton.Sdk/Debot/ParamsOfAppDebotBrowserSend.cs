namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserSend
    {
        #region Properties

        [JsonProperty("message")]
        public string Message { get; set; }

        #endregion
    }
}