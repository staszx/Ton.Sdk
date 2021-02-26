namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    public class ResultOfBocCacheGet
    {
        #region Properties

        [JsonProperty("boc")]
        public string Boc { get; set; }

        #endregion
    }
}