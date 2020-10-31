namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of convert address
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_utils.md#convert_address
    /// </summary>
    public class ParamsOfConvertAddress
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the output format.
        /// </summary>
        /// <value>
        ///     The output format.
        /// </value>
        [JsonProperty("output_format")]
        public AddressStringFormat OutputFormat { get; set; }

        #endregion
    }
}