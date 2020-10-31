namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfModularPower
    {
        #region Properties

        [JsonProperty("modular_power")]
        public string ModularPower { get; set; }

        #endregion
    }
}