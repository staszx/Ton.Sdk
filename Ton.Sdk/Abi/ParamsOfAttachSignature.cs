namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of attach signature
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#paramsofattachsignature
    /// </summary>
    public class ParamsOfAttachSignature
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the contract abi.
        /// </summary>
        /// <value>
        ///     The contract abi.
        /// </value>
        [JsonProperty("abi")]
        public ContractAbi ContractAbi { get; set; }

        /// <summary>
        ///     Gets or sets the public key.
        /// </summary>
        /// <value>
        ///     The public key.
        /// </value>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the signature.
        /// </summary>
        /// <value>
        ///     The signature.
        /// </value>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        #endregion
    }
}