namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Modular Power
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfModularPower
    /// </summary>
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