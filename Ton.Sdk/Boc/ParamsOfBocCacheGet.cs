namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    public class ParamsOfBocCacheGet
    {
        #region Properties

        [JsonProperty("boc_ref")]
        public string BocRef { get; set; }

        #endregion
    }
}