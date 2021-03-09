namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class BocCacheType
    {
        #region Properties

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public PinType Type { get; set; }

        [JsonProperty("pin")]
        public string Pin { get; set; }

        #endregion
    }
}