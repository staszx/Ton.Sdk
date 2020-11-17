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

        /// <summary>
        /// Gets or sets the base.
        /// </summary>
        /// <value>
        /// The base.
        /// </value>
        [JsonProperty("base")]
        public string Base { get; set; }

        /// <summary>
        /// Gets or sets the exponent.
        /// </summary>
        /// <value>
        /// The exponent.
        /// </value>
        [JsonProperty("exponent")]
        public string Exponent { get; set; }

        /// <summary>
        /// Gets or sets the modulus.
        /// </summary>
        /// <value>
        /// The modulus.
        /// </value>
        [JsonProperty("modulus")]
        public string Modulus { get; set; }

        #endregion
    }
}