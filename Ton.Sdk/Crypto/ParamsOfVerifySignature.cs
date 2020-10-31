namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfVerifySignature
    {
        #region Properties

        [JsonProperty("signed")]
        public string Signed { get; set; }

        [JsonProperty("public")]
        public string Public { get; set; }

        #endregion
    }
}