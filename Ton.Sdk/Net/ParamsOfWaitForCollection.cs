namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of wait collection
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#paramsofwaitforcollection
    /// </summary>
    public class ParamsOfWaitForCollection
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the collection.
        /// </summary>
        /// <value>
        ///     The collection.
        /// </value>
        [JsonProperty("collection")]
        public string Collection { get; set; }

        /// <summary>
        ///     Gets or sets the filter.
        /// </summary>
        /// <value>
        ///     The filter.
        /// </value>
        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        /// <summary>
        ///     Gets or sets the result.
        /// </summary>
        /// <value>
        ///     The result.
        /// </value>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        ///     Gets or sets the timeout.
        /// </summary>
        /// <value>
        ///     The timeout.
        /// </value>
        [JsonProperty("timeout")]
        public uint? Timeout { get; set; }

        #endregion
    }
}