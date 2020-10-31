namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of encode message
    /// </summary>
    public class ResultOfEncodeMessage
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
        ///     Gets or sets the data to sign.
        /// </summary>
        /// <value>
        ///     The data to sign.
        /// </value>
        [JsonProperty("data_to_sign")]
        public string DataToSign { get; set; }

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        [JsonProperty("adress")]
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