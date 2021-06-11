namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class TransactionNode
    {
        #region Properties

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("in_msg")]
        public string InMsg { get; set; }

        [JsonProperty("out_msgs")]
        public string[] OutMsgs { get; set; }

        [JsonProperty("account_addr")]
        public string AccountAddr { get; set; }

        [JsonProperty("total_fees")]
        public string TotalFees { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("exit_code")]
        public uint? ExitCode { get; set; }

        #endregion
    }
}