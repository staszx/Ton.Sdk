namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of encode account
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_account
    /// </summary>
    public class ResultOfEncodeAccount
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the account.
        /// </summary>
        /// <value>
        ///     The account.
        /// </value>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        #endregion
    }
}