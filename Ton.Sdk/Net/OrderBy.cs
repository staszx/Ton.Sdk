namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The order by class
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#orderby
    /// </summary>
    public class OrderBy
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the path.
        /// </summary>
        /// <value>
        ///     The path.
        /// </value>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        ///     Gets or sets the direction.
        /// </summary>
        /// <value>
        ///     The direction.
        /// </value>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SortDirection Direction { get; set; }

        #endregion
    }
}