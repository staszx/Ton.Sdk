namespace Ton.Sdk.Utils
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The Adress string format
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_utils.md#AddressStringFormat
    /// </summary>
    public class AddressStringFormat
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public AddressStringFormatType Type { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="AddressStringFormat" /> is test.
        /// </summary>
        /// <value>
        ///     <c>true</c> if test; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("test")]
        public bool Test { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="AddressStringFormat" /> is bounce.
        /// </summary>
        /// <value>
        ///     <c>true</c> if bounce; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("bounce")]
        public bool Bounce { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="AddressStringFormat" /> is URL.
        /// </summary>
        /// <value>
        ///     <c>true</c> if URL; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("url")]
        public bool Url { get; set; }

        #endregion
    }
}