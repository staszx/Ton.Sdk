namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of encode Account
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_account
    /// </summary>
    public class ParamsOfEncodeAccount
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the state initialize.
        /// </summary>
        /// <value>
        ///     The state initialize.
        /// </value>
        [JsonProperty("state_init")]
        public StateInitSource StateInit { get; set; }

        /// <summary>
        ///     Gets or sets the balance.
        /// </summary>
        /// <value>
        ///     The balance.
        /// </value>
        [JsonProperty("balance")]
        public long? Balance { get; set; }

        /// <summary>
        ///     Gets or sets the last trans it.
        /// </summary>
        /// <value>
        ///     The last trans it.
        /// </value>
        [JsonProperty("last_trans_lt")]
        public long? LastTransIt { get; set; }

        /// <summary>
        ///     Gets or sets the last paid.
        /// </summary>
        /// <value>
        ///     The last paid.
        /// </value>
        [JsonProperty("last_paid")]
        public uint LastPaid { get; set; }

        #endregion
    }
}