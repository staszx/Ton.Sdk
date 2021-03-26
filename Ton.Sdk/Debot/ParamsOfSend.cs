namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfSend
    {
        #region Properties

        [JsonProperty("debot_handle")]
        public int DebotHandle { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        #endregion
    }
}