namespace Ton.Sdk.Abi
{
    using Crypto;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The Signer
    /// </summary>
    public class Signer
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public SignerType Type { get;}

        /// <summary>
        /// Gets or sets the public key.
        /// </summary>
        /// <value>
        /// The public key.
        /// </value>
        [JsonProperty("public_key")]
        public string PublicKey { get;}

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        [JsonProperty("keys")]
        public KeyPair Keys { get;}

        /// <summary>
        /// Gets or sets the handle.
        /// </summary>
        /// <value>
        /// The handle.
        /// </value>
        [JsonProperty("handle")]
        public uint Handle { get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="Signer"/> class.
        /// </summary>
        public Signer()
        {
            Type = SignerType.None;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signer"/> class.
        /// </summary>
        /// <param name="publicKey">The public key.</param>
        public Signer(string publicKey)
        {
            Type = SignerType.External;
            PublicKey = publicKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="publicKey">The public key.</param>
        /// <param name="secretKey">The secret key.</param>
        public Signer(string publicKey, string secretKey)
        {
            Type = SignerType.Keys;
            Keys = new KeyPair() { Public = publicKey, Secret = secretKey };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signer"/> class.
        /// </summary>
        /// <param name="handle">The handle.</param>
        public Signer(uint handle)
        {
            Type = SignerType.SigningBox;
            Handle = handle;
        }
    }
}