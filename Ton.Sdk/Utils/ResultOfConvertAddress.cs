namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of convert address
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_utils.md#convert_address
    /// </summary>
    public class ResultOfConvertAddress
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

        #endregion
    }
}