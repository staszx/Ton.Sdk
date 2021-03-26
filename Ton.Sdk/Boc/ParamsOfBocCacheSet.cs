namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ParamsOfBocCacheSet
    {
        #region Properties

        [JsonProperty("boc")]
        public string Boc { get; set; }

        [JsonProperty("cache_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BocCacheType CacheType { get; set; }

        #endregion
    }
}