namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The AbiConfig
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#abiconfig
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
        public float? MessageExpirationTimeoutGrowFactor { get; set; }

        #endregion
    }
}