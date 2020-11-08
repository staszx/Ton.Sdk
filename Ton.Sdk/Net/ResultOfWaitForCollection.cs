namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The result of wait collection
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#resultofwaitforcollection
    /// </summary>
    public class ResultOfWaitForCollection
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the result.
        /// </summary>
        /// <value>
        ///     The result.
        /// </value>
        [JsonProperty("result")]
        public JObject Result { get; set; }

        #endregion
    }
}