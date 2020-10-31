namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The function header
    /// </summary>
    public class FunctionHeader
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the expire.
        /// </summary>
        /// <value>
        ///     The expire.
        /// </value>
        [JsonProperty("expire")]
        public int Expire { get; set; }

        /// <summary>
        ///     Gets or sets the time.
        /// </summary>
        /// <value>
        ///     The time.
        /// </value>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        ///     Gets or sets the pub key.
        /// </summary>
        /// <value>
        ///     The pub key.
        /// </value>
        [JsonProperty("pubkey")]
        public string PubKey { get; set; }

        #endregion
    }
}