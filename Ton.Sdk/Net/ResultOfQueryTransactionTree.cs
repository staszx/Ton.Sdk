namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ResultOfQueryTransactionTree
    {
        #region Properties

        [JsonProperty("messages")]
        public MessageNode[] Messages { get; set; }

        [JsonProperty("transactions")]
        public TransactionNode[] Transactions { get; set; }

        #endregion
    }
}