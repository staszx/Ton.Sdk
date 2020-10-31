namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    /// <summary>
    /// The result of get blockchain config
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_blockchain_config
    /// </summary>
    public class ResultOfGetBlockchainConfig
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the configuration boc.
        /// </summary>
        /// <value>
        ///     The configuration boc.
        /// </value>
        [JsonProperty("config_boc")]
        public string ConfigBoc { get; set; }

        #endregion
    }
}