namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfNaclSign
    {
        #region Properties

        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}