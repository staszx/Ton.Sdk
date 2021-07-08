namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ParamsOfIteratorNext
    {
        [JsonProperty("iterator")]
        public uint Iterator { get; set; }

        [JsonProperty("limit")]
        public uint? Limit { get; set; }

        [JsonProperty("return_resume_state")]
        public bool? ReturnResumeState { get; set; }
    }
}