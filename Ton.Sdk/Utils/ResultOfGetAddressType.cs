namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ResultOfGetAddressType
    {
        #region Properties

        [JsonProperty("address_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountAddressType AddressType { get; set; }

        #endregion
    }
}