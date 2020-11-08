namespace Ton.Sdk.Processing
{
    using System.Threading.Tasks;
    using Request;

    /// <summary>
    ///     The processing module
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Processing : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Processing" /> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        public Processing(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Subscribes the collection.
        /// </summary>
        /// <param name="paramsOfSendMessage">The parameters of send message.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#send_message
        /// <returns>ResultOfSendMessage</returns>
        public async Task<ResultOfSendMessage> SendMessage(ParamsOfSendMessage paramsOfSendMessage, ResponseHandler responseHandler = null)
        {
            return await this.Request<ResultOfSendMessage>("processing.send_message", paramsOfSendMessage, responseHandler);
        }

        /// <summary>
        ///     Waits for transaction.
        /// </summary>
        /// <param name="paramsOfWaitForTransaction">The parameters of wait for transaction.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#wait_for_transaction
        /// <returns>ResultOfProcessMessage</returns>
        public async Task<ResultOfProcessMessage> WaitForTransaction(ParamsOfWaitForTransaction paramsOfWaitForTransaction,
            ResponseHandler responseHandler = null)
        {
            return await this.Request<ResultOfProcessMessage>("processing.wait_for_transaction", paramsOfWaitForTransaction, responseHandler);
        }

        /// <summary>
        ///     Processes the message.
        /// </summary>
        /// <param name="paramsOfProcessMessage">The parameters of process message.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_processing.md#process_message
        /// <returns>ResultOfProcessMessage</returns>
        public async Task<ResultOfProcessMessage> ProcessMessage(ParamsOfProcessMessage paramsOfProcessMessage,
            ResponseHandler responseHandler = null)
        {
            return await this.Request<ResultOfProcessMessage>("processing.process_message", paramsOfProcessMessage, responseHandler);
        }

        #endregion
    }
}