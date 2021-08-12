namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    public class ParamsOfGetAddressType
    {
        #region Properties

        [JsonProperty("address")]
        public string Address { get; set; }

        #endregion
    }
}