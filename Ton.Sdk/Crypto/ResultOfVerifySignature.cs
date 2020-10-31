namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfVerifySignature
    {
        #region Properties

        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        #endregion
    }
}