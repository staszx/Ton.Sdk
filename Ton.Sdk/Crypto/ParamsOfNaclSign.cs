namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSign
    /// </summary>
    public class ParamsOfNaclSign
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unsigned.
        /// </summary>
        /// <value>
        /// The unsigned.
        /// </value>
        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

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