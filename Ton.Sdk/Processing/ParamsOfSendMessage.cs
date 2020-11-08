namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;

    /// <summary>
    /// Params of send message
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#ParamsOfSendMessage
    /// </summary>
    public class ParamsOfSendMessage
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
        /// Gets or sets the contract abi.
        /// </summary>
        /// <value>
        /// The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send events].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send events]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("send_events")]
        public bool SendEvents { get; set; }

        #endregion
    }
}