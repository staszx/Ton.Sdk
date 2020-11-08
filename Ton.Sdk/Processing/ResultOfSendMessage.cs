namespace Ton.Sdk.Processing
{
    using Newtonsoft.Json;

    /// <summary>
    /// The result of send message
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#ResultOfSendMessage
    /// </summary>
    public class ResultOfSendMessage
    {
        #region Properties

        /// <summary>
        /// Gets or sets the shard block identifier.
        /// </summary>
        /// <value>
        /// The shard block identifier.
        /// </value>
        [JsonProperty("shard_block_id")]
        public string ShardBlockId { get; set; }

        #endregion
    }
}