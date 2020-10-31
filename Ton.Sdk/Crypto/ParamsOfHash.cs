namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfHash
    {
        #region Properties

        [JsonProperty("data")]
        public string Data { get; set; }

        #endregion
    }
}