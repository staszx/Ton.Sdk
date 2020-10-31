namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfNaclBox
    {
        #region Properties

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        #endregion
    }
}