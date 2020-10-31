namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of parse
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_message
    /// </summary>
    public class ParamsOfParse
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the boc.
        /// </summary>
        /// <value>
        ///     The boc.
        /// </value>
        [JsonProperty("boc")]
        public string Boc { get; set; }

        #endregion
    }
}