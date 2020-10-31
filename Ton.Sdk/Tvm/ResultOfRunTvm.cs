namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;
    using Processing;

    /// <summary>
    /// The result of run tvm
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#resultofruntvm
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ResultOfRunTvm
    {
        #region Properties

        /// <summary>
        /// Gets or sets the out messages.
        /// </summary>
        /// <value>
        /// The out messages.
        /// </value>
        [JsonProperty("out_messages")] 
        public string[] OutMessages { get; set; }

        /// <summary>
        /// Gets or sets the decoded.
        /// </summary>
        /// <value>
        /// The decoded.
        /// </value>
        [JsonProperty("decoded")] 
        public DecodedOutput Decoded { get; set; }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        /// <value>
        /// The account.
        /// </value>
        [JsonProperty("account")] 
        public string Account { get; set; }

        #endregion
    }
}