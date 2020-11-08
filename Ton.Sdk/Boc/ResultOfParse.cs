namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The result of parse
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_message
    /// </summary>
    public class ResultOfParse
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the parsed.
        /// </summary>
        /// <value>
        ///     The parsed.
        /// </value>
        [JsonProperty("parsed")]
        public JObject Parsed { get; set; }

        #endregion
    }
}