namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfSign
    {
        #region Properties

        [JsonProperty("signed")]
        public string Signed { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        #endregion
    }
}