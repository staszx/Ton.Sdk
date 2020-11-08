namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The Decided message body
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#messagebodytype
    /// </summary>
    public class DecodedMessageBody
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonProperty("body_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageBodyType Type { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        [JsonProperty("value")]
        public object Value { get; set; }

        /// <summary>
        ///     Gets or sets the header.
        /// </summary>
        /// <value>
        ///     The header.
        /// </value>
        [JsonProperty("header")]
        public FunctionHeader Header { get; set; }

        #endregion
    }
}