namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of Chacha20
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#chacha20
    /// </summary>
    public class ParamsOfChacha20
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        /// <value>
        ///     The data.
        /// </value>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        ///     Gets or sets the key.
        /// </summary>
        /// <value>
        ///     The key.
        /// </value>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        ///     Gets or sets the nonce.
        /// </summary>
        /// <value>
        ///     The nonce.
        /// </value>
        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        #endregion
    }
}