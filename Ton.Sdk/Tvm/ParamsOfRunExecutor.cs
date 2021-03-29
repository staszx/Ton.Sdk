namespace Ton.Sdk.Tvm
{
    using Abi;
    using Boc;
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of executor class
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#paramsofrunexecutor
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ParamsOfRunExecutor
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the account.
        /// </summary>
        /// <value>
        ///     The account.
        /// </value>
        [JsonProperty("account")]
        public AccountForExecutor Account { get; set; }

        /// <summary>
        ///     Gets or sets the execution options.
        /// </summary>
        /// <value>
        ///     The execution options.
        /// </value>
        [JsonProperty("execution_options")]
        public ExecutionOptions ExecutionOptions { get; set; }

        /// <summary>
        ///     Gets or sets the contract abi.
        /// </summary>
        /// <value>
        ///     The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [skip transaction check].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [skip transaction check]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("skip_transaction_check")]
        public bool SkipTransactionCheck { get; set; }

        /// <summary>
        /// Gets or sets the boc cache.
        /// </summary>
        /// <value>
        /// The boc cache.
        /// </value>
        [JsonProperty("boc_cache")]
        public BocCacheType BocCache { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [return updated account].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [return updated account]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("return_updated_account")]
        public bool ReturnUpdatedAccount { get; set; }

        #endregion
    }
}