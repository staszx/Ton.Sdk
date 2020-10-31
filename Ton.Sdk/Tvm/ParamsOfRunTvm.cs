namespace Ton.Sdk.Tvm
{
    using Abi;
    using Newtonsoft.Json;

    /// <summary>
    /// The params of run tvm
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#paramsofruntvm
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ParamsOfRunTvm
    {
        #region Properties

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [JsonProperty("message")] 
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        /// <value>
        /// The account.
        /// </value>
        [JsonProperty("account")] 
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the execution options.
        /// </summary>
        /// <value>
        /// The execution options.
        /// </value>
        [JsonProperty("execution_options")] 
        public ExecutionOptions ExecutionOptions { get; set; }

        /// <summary>
        /// Gets or sets the contract abi.
        /// </summary>
        /// <value>
        /// The contract abi.
        /// </value>
        [JsonProperty("abi")] 
        public ContractAbi ContractAbi { get; set; }

        #endregion
    }
}