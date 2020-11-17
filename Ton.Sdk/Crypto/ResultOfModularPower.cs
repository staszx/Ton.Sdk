namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Modular Power
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfModularPower
    /// </summary>
    public class ResultOfModularPower
    {
        #region Properties

        [JsonProperty("modular_power")]
        public string ModularPower { get; set; }

        #endregion
    }
}