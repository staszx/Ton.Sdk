namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of query collection
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#paramsofquerycollection
    /// </summary>
    public class ParamsOfQueryCollection
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
        ///     Gets or sets the order.
        /// </summary>
        /// <value>
        ///     The order.
        /// </value>
        [JsonProperty("order")]
        public OrderBy[] Order { get; set; }

        /// <summary>
        ///     Gets or sets the limit.
        /// </summary>
        /// <value>
        ///     The limit.
        /// </value>
        [JsonProperty("limit")]
        public uint? Limit { get; set; }

        #endregion
    }
}