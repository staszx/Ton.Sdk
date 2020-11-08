namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;

    /// <summary>
    /// The params of wait message transaction
    /// </summary>
    public class ParamsOfWaitForTransaction
    {
        #region Properties

        /// <summary>
        /// Gets or sets the contract abi.
        /// </summary>
        /// <value>
        /// The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the shard block identifier.
        /// </summary>
        /// <value>
        /// The shard block identifier.
        /// </value>
        [JsonProperty("shard_block_id")]
        public string ShardBlockId { get; set; }

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