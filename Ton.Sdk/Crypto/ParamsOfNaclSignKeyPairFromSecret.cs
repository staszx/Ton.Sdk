namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Sign Key Pair From Secret
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSignKeyPairFromSecret
    /// </summary>
    public class ParamsOfNaclSignKeyPairFromSecret
    {
        #region Properties

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