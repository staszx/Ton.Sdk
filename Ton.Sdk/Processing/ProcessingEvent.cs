namespace Ton.Sdk.Processing
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The processing event
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#ProcessingEvent
    /// </summary>
    public class ProcessingEvent
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the error.
        /// </summary>
        /// <value>
        ///     The error.
        /// </value>
        [JsonProperty("error")]
        public ClientError Error { get; set; }

        /// <summary>
        ///     Gets or sets the shard block identifier.
        /// </summary>
        /// <value>
        ///     The shard block identifier.
        /// </value>
        [JsonProperty("shard_block_id")]
        public string ShardBlockId { get; set; }

        /// <summary>
        ///     Gets or sets the message identifier.
        /// </summary>
        /// <value>
        ///     The message identifier.
        /// </value>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        private ProcessingEventTypes ProcessingEventTypes { get; set; }

        #endregion
    }
}