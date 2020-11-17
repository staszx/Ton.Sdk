namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of Generate Random Bytes
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfGenerateRandomBytes
    /// </summary>
    public class ParamsOfGenerateRandomBytes
    {
        #region Properties

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        [JsonProperty("length")] 
        public uint Length { get; set; }

        #endregion
    }
}