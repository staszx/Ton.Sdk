namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Key pair
    /// </summary>
    public class KeyPair
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the public.
        /// </summary>
        /// <value>
        ///     The public.
        /// </value>
        [JsonProperty("public")]
        public string Public { get; set; }

        /// <summary>
        ///     Gets or sets the secret.
        /// </summary>
        /// <value>
        ///     The secret.
        /// </value>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}