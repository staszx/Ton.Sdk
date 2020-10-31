namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;

    public class ParamsOfWaitForTransaction
    {
        #region Properties

        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("shard_block_id")]
        public string ShardBlockId { get; set; }

        [JsonProperty("send_events")]
        public bool SendEvents { get; set; }

        #endregion
    }
}