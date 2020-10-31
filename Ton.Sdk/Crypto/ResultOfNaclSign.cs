namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfNaclSign
    {
        #region Properties

        [JsonProperty("signed")]
        public string Signed { get; set; }

        #endregion
    }
}