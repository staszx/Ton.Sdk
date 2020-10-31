namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfFactorize
    {
        #region Properties

        [JsonProperty("factors")]
        public string[] Factors { get; set; }

        #endregion
    }
}