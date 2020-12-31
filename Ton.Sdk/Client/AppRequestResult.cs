namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    public class AppRequestResult
    {
        #region Properties

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("text")] public string Text { get; set; }

        [JsonProperty("result")] public string Result { get; set; }

        #endregion
    }
}