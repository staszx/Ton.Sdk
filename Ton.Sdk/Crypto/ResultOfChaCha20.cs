namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of chacha20
    /// </summary>
    public class ResultOfChacha20
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        /// <value>
        ///     The data.
        /// </value>
        [JsonProperty("data")]
        public string Data { get; set; }

        #endregion
    }
}