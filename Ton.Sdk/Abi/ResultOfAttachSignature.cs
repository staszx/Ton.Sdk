namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    public class ResultOfAttachSignature
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