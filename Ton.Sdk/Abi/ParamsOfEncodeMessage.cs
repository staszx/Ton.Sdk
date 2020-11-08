namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of encode message
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#ParamsOfEncodeMessage
    /// </summary>
    public class ParamsOfEncodeMessage
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
        ///     Gets or sets the signer.
        /// </summary>
        /// <value>
        ///     The signer.
        /// </value>
        [JsonProperty("signer")]
        public Signer Signer { get; set; }

        /// <summary>
        ///     Gets or sets the index of the processing try.
        /// </summary>
        /// <value>
        ///     The index of the processing try.
        /// </value>
        [JsonProperty("processing_try_index")]
        public uint? ProcessingTryIndex { get; set; }

        #endregion
    }
}