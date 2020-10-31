namespace Ton.Sdk.Processing
{
    using System.Threading.Tasks;
    using Net;

    public class Processing: TonClientModule
    {
        public Processing(TonClient tonClient) : base(tonClient)
        {
        }

        /// <summary>
        /// Subscribes the collection.
        /// </summary>
        /// <param name="paramsOfSendMessage">The parameters of send message.</param>
        /// <returns></returns>
        public async Task<ResultOfSendMessage> SendMessage(ParamsOfSendMessage paramsOfSendMessage) 
        {
            return await this.Request<ResultOfSendMessage>("processing.send_message", paramsOfSendMessage);
        }

        /// <summary>
        /// Waits for transaction.
        /// </summary>
        /// <param name="paramsOfWaitForTransaction">The parameters of wait for transaction.</param>
        /// <returns></returns>
        public async Task<ResultOfProcessMessage> WaitForTransaction(ParamsOfWaitForTransaction paramsOfWaitForTransaction)
        {
            return await this.Request<ResultOfProcessMessage>("processing.wait_for_transaction", paramsOfWaitForTransaction);
        }

        /// <summary>
        /// Processes the message.
        /// </summary>
        /// <param name="paramsOfProcessMessage">The parameters of process message.</param>
        /// <returns></returns>
        public async Task<ResultOfProcessMessage> ProcessMessage(ParamsOfProcessMessage paramsOfProcessMessage)
        {
            return await this.Request<ResultOfProcessMessage>("processing.process_message", paramsOfProcessMessage);
        }

    }
}
