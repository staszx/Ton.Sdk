namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of process message
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#ParamsOfProcessMessage
    /// </summary>
    public class ParamsOfProcessMessage
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the message encode parameters.
        /// </summary>
        /// <value>
        ///     The message encode parameters.
        /// </value>
        [JsonProperty("message_encode_params")]
        public ParamsOfEncodeMessage MessageEncodeParams { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [send events].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [send events]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("send_events")]
        public bool SendEvents { get; set; }

        #endregion
    }
}