namespace Ton.Sdk.Processing
{
    using Newtonsoft.Json;
    using Tvm;

    public class ResultOfProcessMessage
    {
        #region Properties

        [JsonProperty("transaction")]
        public object Transaction { get; set; }

        [JsonProperty("out_messages")]
        public string[] OutMessages { get; set; }

        [JsonProperty("decoded")]
        public DecodedOutput Decoded { get; set; }

        [JsonProperty("fees")]
        public TransactionFees Fees { get; set; }

        #endregion
    }
}