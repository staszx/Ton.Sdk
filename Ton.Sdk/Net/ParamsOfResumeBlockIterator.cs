namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ParamsOfResumeBlockIterator
    {
        [JsonProperty("resume_state")]
        public object ResumeState { get; set; }
    }
}