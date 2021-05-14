namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#query_counterparties
    /// </summary>
    public class ParamsOfQueryCounterparties
    {
        #region Properties

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("first")]
        public uint? First { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }

        #endregion
    }
}