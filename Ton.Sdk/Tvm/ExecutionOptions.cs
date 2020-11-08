namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The class execution options
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#executionoptions
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ExecutionOptions
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the blockchain configuration.
        /// </summary>
        /// <value>
        ///     The blockchain configuration.
        /// </value>
        [JsonProperty("blockchain_config")]
        public string BlockchainConfig { get; set; }

        /// <summary>
        ///     Gets or sets the block time.
        /// </summary>
        /// <value>
        ///     The block time.
        /// </value>
        [JsonProperty("block_time")]
        public int BlockTime { get; set; }

        /// <summary>
        ///     Gets or sets the block lt.
        /// </summary>
        /// <value>
        ///     The block lt.
        /// </value>
        [JsonProperty("block_lt")]
        public long BlockLt { get; set; }

        /// <summary>
        ///     Gets or sets the transaction lt.
        /// </summary>
        /// <value>
        ///     The transaction lt.
        /// </value>
        [JsonProperty("transaction_lt")]
        public long TransactionLt { get; set; }

        #endregion
    }
}