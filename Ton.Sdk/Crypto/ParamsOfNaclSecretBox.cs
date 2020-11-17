namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Secret Box
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSecretBox
    /// </summary>
    public class ParamsOfNaclSecretBox
    {
        #region Properties

        /// <summary>
        /// Gets or sets the decrypted.
        /// </summary>
        /// <value>
        /// The decrypted.
        /// </value>
        [JsonProperty("decrypted")]
        public string Decrypted { get; set; }

        /// <summary>
        /// Gets or sets the nonce.
        /// </summary>
        /// <value>
        /// The nonce.
        /// </value>
        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}