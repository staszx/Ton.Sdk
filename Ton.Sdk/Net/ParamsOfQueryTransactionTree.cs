namespace Ton.Sdk.Net
{
    using Abi;
    using Newtonsoft.Json;

    public class ParamsOfQueryTransactionTree
    {
        #region Properties

        [JsonProperty("in_msg")]
        public string InMsg { get; set; }

        [JsonProperty("abi_registry")]
        public ContractAbi[] AbiRegistry { get; set; }

        #endregion
    }
}