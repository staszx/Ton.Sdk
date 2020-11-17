namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Secret Box Open
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSecretBoxOpen
    /// </summary>
    public class ParamsOfNaclSecretBoxOpen
    {
        #region Properties

        /// <summary>
        /// Gets or sets the encrypted.
        /// </summary>
        /// <value>
        /// The encrypted.
        /// </value>
        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

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