namespace Ton.Sdk.BOC
{
    using Newtonsoft.Json;

    /// <summary>
    /// The result of boc hash
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_boc_hash
    /// </summary>
    public class ResultOfGetBocHash
    {
        #region Properties

        /// <summary>
        /// Gets or sets the hash.
        /// </summary>
        /// <value>
        /// The hash.
        /// </value>
        [JsonProperty("hash")] 
        public string Hash { get; set; }

        #endregion
    }
}