namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    /// <summary>
    /// The debot action
    /// </summary>
    public class DebotAction
    {
        #region Properties

        [JsonProperty("description")] 
        public string Description { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }

        [JsonProperty("action_type")] 
        public uint ActionType { get; set; }

        [JsonProperty("to")] 
        public uint To { get; set; }

        [JsonProperty("attributes")] 
        public string Attributes { get; set; }

        [JsonProperty("misc")] public string Misc { get; set; }

        #endregion
    }
}