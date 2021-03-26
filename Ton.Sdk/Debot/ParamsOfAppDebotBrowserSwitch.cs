namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserSwitch
    {
        #region Properties

        [JsonProperty("context_id")]
        public uint ContextId { get; set; }

        #endregion
    }
}