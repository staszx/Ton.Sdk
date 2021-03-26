namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ParamsOfCalcStorageFee
    {
        #region Properties

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("period")]
        public uint Period { get; set; }

        #endregion
    }
}