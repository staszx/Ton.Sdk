namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The client Error
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#clienterror
    /// </summary>
    public class ClientError
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the code.
        /// </summary>
        /// <value>
        ///     The code.
        /// </value>
        [JsonProperty("code")]
        public uint Code { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        /// <value>
        ///     The data.
        /// </value>
        [JsonProperty("data")]
        public object Data { get; set; }

        #endregion
    }
}