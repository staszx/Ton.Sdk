namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfNaclSignOpen
    {
        #region Properties

        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        #endregion
    }
}