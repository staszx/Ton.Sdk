namespace Ton.Sdk.BOC
{
    using Newtonsoft.Json;

    /// <summary>
    /// The  params of parse shardstate
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_shardstate
    /// </summary>
    public class ParamsOfParseShardstate
    {
        #region Properties

        /// <summary>
        /// Gets or sets the boc.
        /// </summary>
        /// <value>
        /// The boc.
        /// </value>
        [JsonProperty("boc")] 
        public string Boc { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")] 
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the workchain identifier.
        /// </summary>
        /// <value>
        /// The workchain identifier.
        /// </value>
        [JsonProperty("workchain_id")] 
        public uint WorkchainId { get; set; }

        #endregion
    }
}