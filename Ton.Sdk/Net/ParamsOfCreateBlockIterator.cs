namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ParamsOfCreateBlockIterator
    {
        [JsonProperty("start_time")]
        public uint? StartTime { get; set; }

        [JsonProperty("end_time")]
        public uint? EndTime { get; set; }

        [JsonProperty("shard_filter")]
        public string[] ShardFilter { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }
}