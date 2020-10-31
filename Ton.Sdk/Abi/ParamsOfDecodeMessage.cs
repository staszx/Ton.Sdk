namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    /// The params of decode message
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#paramsofdecodemessage
    /// </summary>
    public class ParamsOfDecodeMessage
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the abi.
        /// </summary>
        /// <value>
        ///     The abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        #endregion
    }
}