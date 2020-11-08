namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Processing;

    /// <summary>
    ///     The Result of run executor
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#run_executor
    /// </summary>
    public class ResultOfRunExecutor
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the transaction.
        /// </summary>
        /// <value>
        ///     The transaction.
        /// </value>
        [JsonProperty("transaction")]
        public JObject Transaction { get; set; }

        /// <summary>
        ///     Gets or sets the out messages.
        /// </summary>
        /// <value>
        ///     The out messages.
        /// </value>
        [JsonProperty("out_messages")]
        public string[] OutMessages { get; set; }

        /// <summary>
        ///     Gets or sets the decoded.
        /// </summary>
        /// <value>
        ///     The decoded.
        /// </value>
        [JsonProperty("decoded")]
        public DecodedOutput Decoded { get; set; }

        /// <summary>
        ///     Gets or sets the account.
        /// </summary>
        /// <value>
        ///     The account.
        /// </value>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        ///     Gets or sets the fees.
        /// </summary>
        /// <value>
        ///     The fees.
        /// </value>
        [JsonProperty("fees")]
        public TransactionFees Fees { get; set; }

        #endregion
    }
}