namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    public class ParamsOfBocCacheSet
    {
        #region Properties

        [JsonProperty("boc")]
        public string Boc { get; set; }

        [JsonProperty("cache_type")]
        public BocCacheType CacheType { get; set; }

        #endregion
    }
}