namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The result of query collection
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#resultofquerycollection
    /// </summary>
    public class ResultOfQueryCollection
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the result.
        /// </summary>
        /// <value>
        ///     The result.
        /// </value>
        [JsonProperty("result")]
        public JObject[] Result { get; set; }

        #endregion
    }
}