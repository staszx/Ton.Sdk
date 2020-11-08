namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of Decode message body
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#paramsofdecodemessagebody
    /// </summary>
    public class ParamsOfDecodeMessageBody
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the contract abi.
        /// </summary>
        /// <value>
        ///     The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        ///     Gets or sets the body.
        /// </summary>
        /// <value>
        ///     The body.
        /// </value>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is internal.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is internal; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_internal")]
        public bool IsInternal { get; set; }

        #endregion
    }
}