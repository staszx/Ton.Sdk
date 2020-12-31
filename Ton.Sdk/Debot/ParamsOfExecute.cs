namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfExecute
    {
        #region Properties

        [JsonProperty("debot_handle")] 
        public int DebotHandle { get; set; }

        [JsonProperty("action")] 
        public DebotAction Action { get; set; }

        #endregion
    }
}