namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;

    public class ParamsOfSendMessage
    {
        #region Properties

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        [JsonProperty("send_events")]
        public bool SendEvents { get; set; }

        #endregion
    }
}