namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ResultOfCalcStorageFee
    {
        #region Properties

        [JsonProperty("fee")]
        public string Fee { get; set; }

        #endregion
    }
}