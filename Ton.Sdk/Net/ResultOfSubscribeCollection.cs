namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
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