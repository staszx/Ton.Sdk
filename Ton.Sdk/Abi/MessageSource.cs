namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The Message source
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#messagesource
    /// </summary>
    public class MessageSource
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSource"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="abi">The abi.</param>
        public MessageSource(string message, ContractAbi abi = null)
        {
            this.Type = MessageSourceType.Encoded;
            this.Message = message;
            this.ContractAbi = abi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSource"/> class.
        /// </summary>
        /// <param name="abi">The abi.</param>
        /// <param name="address">The address.</param>
        /// <param name="deploySet">The deploy set.</param>
        /// <param name="callSet">The call set.</param>
        /// <param name="signer">The signer.</param>
        /// <param name="processingTryIndex">Index of the processing try.</param>
        public MessageSource(ContractAbi abi, string address, DeploySet deploySet, CallSet callSet, Signer signer, uint? processingTryIndex = null)
        {
            this.Type = MessageSourceType.EncodingParams;
            this.ContractAbi = abi;
            this.Address = address;
            this.DeploySet = deploySet;
            this.CallSet = callSet;
            this.Signer = signer;
            this.ProcessingTryIndex = processingTryIndex;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageSourceType Type { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the contract abi.
        /// </summary>
        /// <value>
        ///     The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        [JsonProperty("adress")]
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the deploy set.
        /// </summary>
        /// <value>
        ///     The deploy set.
        /// </value>
        [JsonProperty("deploy_set")]
        public DeploySet DeploySet { get; set; }

        /// <summary>
        ///     Gets or sets the call set.
        /// </summary>
        /// <value>
        ///     The call set.
        /// </value>
        [JsonProperty("call_set")]
        public CallSet CallSet { get; set; }

        /// <summary>
        ///     Gets or sets the signer.
        /// </summary>
        /// <value>
        ///     The signer.
        /// </value>
        [JsonProperty("signer")]
        public Signer Signer { get; set; }

        /// <summary>
        ///     Gets or sets the index of the processing try.
        /// </summary>
        /// <value>
        ///     The index of the processing try.
        /// </value>
        [JsonProperty("processing_try_index")]
        public uint? ProcessingTryIndex { get; set; }

        #endregion
    }
}