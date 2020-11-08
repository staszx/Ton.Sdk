namespace Ton.Sdk.Abi
{
    using Crypto;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The Signer
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#signer
    /// </summary>
    public class Signer
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        public Signer()
        {
            this.Type = SignerType.None;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="publicKey">The public key.</param>
        public Signer(string publicKey)
        {
            this.Type = SignerType.External;
            this.PublicKey = publicKey;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="publicKey">The public key.</param>
        /// <param name="secretKey">The secret key.</param>
        public Signer(string publicKey, string secretKey)
        {
            this.Type = SignerType.Keys;
            this.Keys = new KeyPair
            {
                Public = publicKey
                , Secret = secretKey
            };
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="handle">The handle.</param>
        public Signer(uint handle)
        {
            this.Type = SignerType.SigningBox;
            this.Handle = handle;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public SignerType Type { get; }

        /// <summary>
        ///     Gets or sets the public key.
        /// </summary>
        /// <value>
        ///     The public key.
        /// </value>
        [JsonProperty("public_key")]
        public string PublicKey { get; }

        /// <summary>
        ///     Gets or sets the keys.
        /// </summary>
        /// <value>
        ///     The keys.
        /// </value>
        [JsonProperty("keys")]
        public KeyPair Keys { get; }

        /// <summary>
        ///     Gets or sets the handle.
        /// </summary>
        /// <value>
        ///     The handle.
        /// </value>
        [JsonProperty("handle")]
        public uint Handle { get; }

        #endregion
    }
}