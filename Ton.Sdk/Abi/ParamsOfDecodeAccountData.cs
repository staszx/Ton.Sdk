namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    public class ParamsOfDecodeAccountData
    {
        #region Properties

        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        #endregion
    }
}