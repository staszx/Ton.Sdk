namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The contract ABI
    /// </summary>
    public class ContractAbi
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContractAbi" /> class.
        /// </summary>
        /// <param name="abiContract">The abi contract.</param>
        public ContractAbi(string abiContract)
        {
            this.Value = abiContract;
            this.Type = ContractAbiType.Serialized;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContractAbi" /> class.
        /// </summary>
        /// <param name="abiContractHandle">The abi contract handle.</param>
        public ContractAbi(int abiContractHandle)
        {
            this.Value = abiContractHandle;
            this.Type = ContractAbiType.Handle;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public ContractAbiType Type { get; }

        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        [JsonProperty("value")]
        public object Value { get; }

        #endregion
    }
}