namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    public class ResultOfDecodeData
    {
        #region Properties

        [JsonProperty("data")]
        public object Data { get; set; }

        #endregion
    }
}