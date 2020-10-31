namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class NetworkConfig
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the server address.
        /// </summary>
        /// <value>
        ///     The server address.
        /// </value>
        [JsonProperty("server_address")]
        public string ServerAddress { get; set; }

        /// <summary>
        ///     Gets or sets the network retries count.
        /// </summary>
        /// <value>
        ///     The network retries count.
        /// </value>
        [JsonProperty("network_retries_count")]
        public uint? NetworkRetriesCount { get; set; }

        /// <summary>
        ///     Gets or sets the message retries count.
        /// </summary>
        /// <value>
        ///     The message retries count.
        /// </value>
        [JsonProperty("message_retries_count")]
        public uint? MessageRetriesCount { get; set; }

        /// <summary>
        ///     Gets or sets the message processing timeout.
        /// </summary>
        /// <value>
        ///     The message processing timeout.
        /// </value>
        [JsonProperty("message_processing_timeout")]
        public uint? MessageProcessingTimeout { get; set; }

        /// <summary>
        ///     Gets or sets the wait for timeout.
        /// </summary>
        /// <value>
        ///     The wait for timeout.
        /// </value>
        [JsonProperty("wait_for_timeout")]
        public uint? WaitForTimeout { get; set; }

        /// <summary>
        ///     Gets or sets the out of synchronize threshold.
        /// </summary>
        /// <value>
        ///     The out of synchronize threshold.
        /// </value>
        [JsonProperty("out_of_sync_threshold")]
        public long? OutOfSyncThreshold { get; set; }

        /// <summary>
        ///     Gets or sets the access key.
        /// </summary>
        /// <value>
        ///     The access key.
        /// </value>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        #endregion
    }
}