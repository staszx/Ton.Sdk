namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
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
        public SortDirection Direction { get; set; }

        #endregion
    }
}