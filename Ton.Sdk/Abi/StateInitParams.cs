namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The state init params
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#stateinitparams
    /// </summary>
    public class StateInitParams
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the contract abi.
        /// </summary>
        /// <value>
        ///     The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        [JsonProperty("value")]
        public object Value { get; set; }

        #endregion
    }
}