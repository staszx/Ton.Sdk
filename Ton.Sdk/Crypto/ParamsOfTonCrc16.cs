namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfTonCrc16
    {
        #region Properties

        [JsonProperty("data")]
        public string Data { get; set; }

        #endregion
    }
}