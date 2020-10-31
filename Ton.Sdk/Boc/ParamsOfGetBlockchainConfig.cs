namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    /// <summary>
    /// The params of get blockchain config
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_blockchain_config
    /// </summary>
    public class ParamsOfGetBlockchainConfig
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the block boc.
        /// </summary>
        /// <value>
        ///     The block boc.
        /// </value>
        [JsonProperty("block_boc")]
        public string BlockBoc { get; set; }

        #endregion
    }
}