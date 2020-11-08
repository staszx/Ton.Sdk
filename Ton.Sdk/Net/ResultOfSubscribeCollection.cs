namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of subscribe collection
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#resultofsubscribecollection
    /// </summary>
    public class ResultOfSubscribeCollection
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the handle.
        /// </summary>
        /// <value>
        ///     The handle.
        /// </value>
        [JsonProperty("handle")]
        public uint Handle { get; set; }

        #endregion
    }
}