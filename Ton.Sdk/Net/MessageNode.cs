namespace Ton.Sdk.Net
{
    using Abi;
    using Newtonsoft.Json;

    public class MessageNode
    {
        #region Properties

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("src_transaction_id")]
        public string SrcTransactionId { get; set; }

        [JsonProperty("dst_transaction_id")]
        public string DstTransactionId { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("dst")]
        public string Dst { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("bounce")]
        public bool Bounce { get; set; }

        [JsonProperty("decoded_body")]
        public DecodedMessageBody DecodedBody { get; set; }

        #endregion
    }
}