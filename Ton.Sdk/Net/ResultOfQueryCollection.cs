namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    /// <summary>
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
        public object[] Result { get; set; }

        #endregion
    }
}