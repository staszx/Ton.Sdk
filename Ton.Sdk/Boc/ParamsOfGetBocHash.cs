namespace Ton.Sdk.BOC
{
    using Newtonsoft.Json;

    /// <summary>
    /// The params of Boc hash
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_boc_hash
    /// </summary>
    public class ParamsOfGetBocHash
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

        #endregion
    }
}