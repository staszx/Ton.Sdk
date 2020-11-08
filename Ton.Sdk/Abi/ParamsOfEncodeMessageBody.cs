namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    /// The params of encode message body
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#ParamsOfEncodeMessageBody
    /// </summary>
    public class ParamsOfEncodeMessageBody
    {
        /// <summary>
        /// Gets or sets the contract abi.
        /// </summary>
        /// <value>
        /// The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        /// Gets or sets the call set.
        /// </summary>
        /// <value>
        /// The call set.
        /// </value>
        [JsonProperty("call_set")]
        public CallSet CallSet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is internal.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is internal; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_internal")]
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the signer.
        /// </summary>
        /// <value>
        /// The signer.
        /// </value>
        [JsonProperty("signer")]
        public Signer Signer { get; set; }

        /// <summary>
        /// Gets or sets the index of the processing try.
        /// </summary>
        /// <value>
        /// The index of the processing try.
        /// </value>
        [JsonProperty("processing_try_index")]
        public int? ProcessingTryIndex { get; set; }
    }
}
