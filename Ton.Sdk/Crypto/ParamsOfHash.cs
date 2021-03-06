namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params of Hash
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHash
    /// </summary>
    public class ParamsOfHash
    {
        #region Properties

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonProperty("data")] 
        public string Data { get; set; }

        #endregion
    }
}