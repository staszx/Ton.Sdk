namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Scrypt
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfScrypt
    /// </summary>
    public class ParamsOfScrypt
    {
        #region Properties

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the salt.
        /// </summary>
        /// <value>
        /// The salt.
        /// </value>
        [JsonProperty("salt")]
        public string Salt { get; set; }

        /// <summary>
        /// Gets or sets the log n.
        /// </summary>
        /// <value>
        /// The log n.
        /// </value>
        [JsonProperty("log_n")]
        public uint LogN { get; set; }

        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        /// <value>
        /// The r.
        /// </value>
        [JsonProperty("r")]
        public uint R { get; set; }

        /// <summary>
        /// Gets or sets the p.
        /// </summary>
        /// <value>
        /// The p.
        /// </value>
        [JsonProperty("p")]
        public uint P { get; set; }

        /// <summary>
        /// Gets or sets the length of the dk.
        /// </summary>
        /// <value>
        /// The length of the dk.
        /// </value>
        [JsonProperty("dk_len")]
        public uint DkLen { get; set; }

        #endregion
    }
}