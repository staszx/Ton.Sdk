namespace Ton.Sdk.Processing
{
    using Abi;
    using Newtonsoft.Json;

    /// <summary>
    ///     The decoded output
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#decodedoutput
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class DecodedOutput
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the out messages.
        /// </summary>
        /// <value>
        ///     The out messages.
        /// </value>
        [JsonProperty("out_messages")]
        public DecodedMessageBody OutMessages { get; set; }

        /// <summary>
        ///     Gets or sets the output.
        /// </summary>
        /// <value>
        ///     The output.
        /// </value>
        [JsonProperty("output")]
        public object Output { get; set; }

        #endregion
    }
}