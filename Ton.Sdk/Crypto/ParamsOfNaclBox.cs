namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Box
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclBox
    /// </summary>
    public class ParamsOfNaclBox
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
        /// Gets or sets their public.
        /// </summary>
        /// <value>
        /// Their public.
        /// </value>
        [JsonProperty("their_public")]
        public string TheirPublic { get; set; }

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}