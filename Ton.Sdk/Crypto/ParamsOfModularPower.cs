namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfModularPower
    {
        #region Properties

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("exponent")]
        public string Exponent { get; set; }

        [JsonProperty("modulus")]
        public string Modulus { get; set; }

        #endregion
    }
}