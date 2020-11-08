namespace Ton.Sdk.Abi
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The Abi module
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Abi : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Abi" /> class.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#module-abi
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        internal Abi(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Encodes the message body.
        /// </summary>
        /// <param name="paramsOfEncodeMessageBody">The parameters of encode message body.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_message_body
        /// <returns>ResultOfEncodeMessageBody</returns>
        public async Task<ResultOfEncodeMessageBody> EncodeMessageBody(ParamsOfEncodeMessageBody paramsOfEncodeMessageBody)
        {
            return await this.Request<ResultOfEncodeMessageBody>("abi.encode_message_body", paramsOfEncodeMessageBody);
        }

        /// <summary>
        ///     Attaches the signature to message body.
        /// </summary>
        /// <param name="paramsOfAttachSignatureToMessageBody">The parameters of attach signature to message body.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#attach_signature_to_message_body
        /// <returns>ResultOfAttachSignature</returns>
        public async Task<ResultOfAttachSignature> AttachSignatureToMessageBody(
            ParamsOfAttachSignatureToMessageBody paramsOfAttachSignatureToMessageBody)
        {
            return await this.Request<ResultOfAttachSignature>("abi.attach_signature_to_message_body", paramsOfAttachSignatureToMessageBody);
        }

        /// <summary>
        ///     Encodes the message.
        /// </summary>
        /// <param name="paramsOfEncodeMessage">The parameters of encode message.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_message
        /// <returns>ResultOfEncodeMessage</returns>
        public async Task<ResultOfEncodeMessage> EncodeMessage(ParamsOfEncodeMessage paramsOfEncodeMessage)
        {
            return await this.Request<ResultOfEncodeMessage>("abi.encode_message", paramsOfEncodeMessage);
        }

        /// <summary>
        ///     Encodes the message.
        /// </summary>
        /// <param name="paramsOfAttachSignature">The parameters of attach signature.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#attach_signature
        /// <returns>ResultOfAttachSignature</returns>
        public async Task<ResultOfAttachSignature> AttachSignature(ParamsOfAttachSignature paramsOfAttachSignature)
        {
            return await this.Request<ResultOfAttachSignature>("abi.attach_signature", paramsOfAttachSignature);
        }

        /// <summary>
        ///     Decodes the message.
        /// </summary>
        /// <param name="paramsOfDecodeMessage">The parameters of decode message.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#decode_message
        /// <returns>DecodedMessageBody</returns>
        public async Task<DecodedMessageBody> DecodeMessage(ParamsOfDecodeMessage paramsOfDecodeMessage)
        {
            return await this.Request<DecodedMessageBody>("abi.decode_message", paramsOfDecodeMessage);
        }

        /// <summary>
        ///     Decodes the message body.
        /// </summary>
        /// <param name="paramsOfDecodeMessageBody">The parameters of decode message body.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#decode_message
        /// <returns>DecodedMessageBody</returns>
        public async Task<DecodedMessageBody> DecodeMessageBody(ParamsOfDecodeMessageBody paramsOfDecodeMessageBody)
        {
            return await this.Request<DecodedMessageBody>("abi.decode_message_body", paramsOfDecodeMessageBody);
        }

        /// <summary>
        ///     Encodes the message.
        /// </summary>
        /// <param name="paramsOfEncodeAccount">The parameters of encode account.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#encode_account
        /// <returns>ResultOfEncodeAccount</returns>
        public async Task<ResultOfEncodeAccount> EncodeAccount(ParamsOfEncodeAccount paramsOfEncodeAccount)
        {
            return await this.Request<ResultOfEncodeAccount>("abi.encode_account", paramsOfEncodeAccount);
        }

        #endregion
    }
}