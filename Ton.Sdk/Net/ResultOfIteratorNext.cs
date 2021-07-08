namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ResultOfIteratorNext
    {
        [JsonProperty("items")]
        public object[] Items { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("resume_state")]
        public object ResumeState { get; set; }
    }
}