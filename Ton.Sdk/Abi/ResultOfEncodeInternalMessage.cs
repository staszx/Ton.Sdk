namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of encode message
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_internal_message
    /// </summary>
    public class ResultOfEncodeInternalMessage
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the message identifier.
        /// </summary>
        /// <value>
        ///     The message identifier.
        /// </value>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        #endregion
    }
}