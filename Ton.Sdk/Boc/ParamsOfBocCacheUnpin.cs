namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    public class ParamsOfBocCacheUnpin
    {
        #region Properties

        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("boc_ref")]
        public string BocRef { get; set; }

        #endregion
    }
}