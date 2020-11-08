namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;

    /// <summary>
    /// The transaction Fees
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#TransactionFees
    /// </summary>
    public class TransactionFees
    {
        #region Properties

        /// <summary>
        /// Gets or sets the in MSG forward fee.
        /// </summary>
        /// <value>
        /// The in MSG forward fee.
        /// </value>
        [JsonProperty("in_msg_fwd_fee")]
        public long InMsgFwdFee { get; set; }

        /// <summary>
        /// Gets or sets the storage fee.
        /// </summary>
        /// <value>
        /// The storage fee.
        /// </value>
        [JsonProperty("storage_fee")]
        public long StorageFee { get; set; }

        [JsonProperty("gas_fee")]
        public long GasFee { get; set; }

        /// <summary>
        /// Gets or sets the out MSGS forward fee.
        /// </summary>
        /// <value>
        /// The out MSGS forward fee.
        /// </value>
        [JsonProperty("out_msgs_fwd_fee")]
        public long OutMsgsFwdFee { get; set; }

        /// <summary>
        /// Gets or sets the total account fees.
        /// </summary>
        /// <value>
        /// The total account fees.
        /// </value>
        [JsonProperty("total_account_fees")]
        public long TotalAccountFees { get; set; }

        /// <summary>
        /// Gets or sets the total output.
        /// </summary>
        /// <value>
        /// The total output.
        /// </value>
        [JsonProperty("total_output")]
        public long TotalOutput { get; set; }

        #endregion
    }
}