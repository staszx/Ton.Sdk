namespace Ton.Sdk.Processing
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ProcessingEvent
    {
        #region Properties

        [JsonProperty("error")]
        public ClientError Error { get; set; }

        [JsonProperty("shard_block_id")]
        public string ShardBlockId { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        private ProcessingEventTypes ProcessingEventTypes { get; set; }

        #endregion
    }
}