namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Client Config
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#clientconfig
    /// </summary>
    public class ClientConfig
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ClientConfig" /> class.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="timeOut">The time out.</param>
        public ClientConfig(string serverAddress, int timeOut)
        {
            this.Network = new NetworkConfig
            {
                  ServerAddress = serverAddress
                , MessageProcessingTimeout = (uint) timeOut
                , WaitForTimeout = (uint) timeOut
                , NetworkRetriesCount = 5
                , MessageRetriesCount = 5
                , OutOfSyncThreshold = 15000
                , AccessKey = ""
            };
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ClientConfig" /> class.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        public ClientConfig(string serverAddress) : this(serverAddress, 50000)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ClientConfig" /> class.
        /// </summary>
        public ClientConfig()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the network.
        /// </summary>
        /// <value>
        ///     The network.
        /// </value>
        [JsonProperty("network")]
        public NetworkConfig Network { get; set; }

        /// <summary>
        ///     Gets or sets the crypto.
        /// </summary>
        /// <value>
        ///     The crypto.
        /// </value>
        [JsonProperty("crypto")]
        public CryptoConfig Crypto { get; set; }

        /// <summary>
        ///     Gets or sets the abi.
        /// </summary>
        /// <value>
        ///     The abi.
        /// </value>
        [JsonProperty("abi")]
        public AbiConfig Abi { get; set; }

        #endregion
    }
}