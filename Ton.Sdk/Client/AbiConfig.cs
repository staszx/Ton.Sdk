namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class AbiConfig
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the workchain.
        /// </summary>
        /// <value>
        ///     The workchain.
        /// </value>
        [JsonProperty("workchain")]
        public uint? Workchain { get; set; }

        /// <summary>
        ///     Gets or sets the message expiration timeout.
        /// </summary>
        /// <value>
        ///     The message expiration timeout.
        /// </value>
        [JsonProperty("message_expiration_timeout")]
        public uint? MessageExpirationTimeout { get; set; }

        /// <summary>
        ///     Gets or sets the message expiration timeout grow factor.
        /// </summary>
        /// <value>
        ///     The message expiration timeout grow factor.
        /// </value>
        [JsonProperty("message_expiration_timeout_grow_factor")]
        public uint? MessageExpirationTimeoutGrowFactor { get; set; }

        #endregion
    }
}