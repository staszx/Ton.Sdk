namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    public class ClientConfig
    {
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