namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;
    using Request;
    using Tvm;

    public class ParamsOfProcessMessage
    {
        #region Properties

        [JsonProperty("message_encode_params")]
        public ParamsOfEncodeMessage MessageEncodeParams { get; set; }

        [JsonProperty("send_events")]
        public bool SendEvents { get; set; }

        [JsonProperty("transaction")]
        public object Transaction { get; set; }

        [JsonProperty("out_messages")]
        public string[] OutMessages { get; set; }

        [JsonProperty("decoded")]
        public DecodedOutput Decoded { get; set; }

        [JsonProperty("fees")]
        public TransactionFees Fees { get; set; }

        [JsonProperty("params")]
        public ParamsOfProcessMessage Params { get; set; }

        [JsonProperty("responseHandler")]
        public ResponseHandler Responsehandler { get; set; }

        #endregion
    }
}