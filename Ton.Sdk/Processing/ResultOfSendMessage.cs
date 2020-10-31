namespace Ton.Sdk.Processing
{
    using Newtonsoft.Json;

    public class ResultOfSendMessage
    {
        #region Properties

        [JsonProperty("shard_block_id")]
        public string ShardBlockId { get; set; }

        #endregion
    }
}