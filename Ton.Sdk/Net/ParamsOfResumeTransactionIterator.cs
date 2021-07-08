namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ParamsOfResumeTransactionIterator
    {
        [JsonProperty("resume_state")]
        public object ResumeState { get; set; }

        [JsonProperty("accounts_filter")]
        public string[] AccountsFilter { get; set; }
    }
}