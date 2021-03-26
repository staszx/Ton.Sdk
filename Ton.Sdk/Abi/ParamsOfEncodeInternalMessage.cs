namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of encode message
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_internal_message
    /// </summary>
    public class ParamsOfEncodeInternalMessage
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
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the source address.
        /// </summary>
        /// <value>
        /// The source address.
        /// </value>
        [JsonProperty("src_address")]
        public string SrcAddress { get; set; }

        /// <summary>
        ///     Gets or sets the deploy set.
        /// </summary>
        /// <value>
        ///     The deploy set.
        /// </value>
        [JsonProperty("deploy_set")]
        public DeploySet DeploySet { get; set; }

        /// <summary>
        ///     Gets or sets the call set.
        /// </summary>
        /// <value>
        ///     The call set.
        /// </value>
        [JsonProperty("call_set")]
        public CallSet CallSet { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the bounce.
        /// </summary>
        /// <value>
        /// The bounce.
        /// </value>
        [JsonProperty("bounce")]
        public bool? Bounce { get; set; }

        /// <summary>
        /// Gets or sets the enable ihr.
        /// </summary>
        /// <value>
        /// The enable ihr.
        /// </value>
        [JsonProperty("enable_ihr")]
        public bool? EnableIhr { get; set; }
        #endregion
    }
}