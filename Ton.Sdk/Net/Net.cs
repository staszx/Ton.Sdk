namespace Ton.Sdk.Net
{
    using System.Threading.Tasks;

    public class Net : TonClientModule
    {
        #region Constructors

        public Net(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Attaches the signature to message body.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#query_collection
        /// </summary>
        /// <param name="paramsOfQueryCollection">The parameters of query collection.</param>
        /// <returns>ResultOfQueryCollection</returns>
        public async Task<ResultOfQueryCollection> QueryCollection(ParamsOfQueryCollection paramsOfQueryCollection)
        {
            return await this.Request<ResultOfQueryCollection>("net.query_collection", paramsOfQueryCollection);
        }

        /// <summary>
        /// Waits for collection.
        /// </summary>
        /// <param name="paramsOfWaitForCollection">The parameters of wait for collection.</param>
        /// <returns></returns>
        public async Task<ResultOfWaitForCollection> WaitForCollection(ParamsOfWaitForCollection paramsOfWaitForCollection)
        {
            return await this.Request<ResultOfWaitForCollection>("net.wait_for_collection", paramsOfWaitForCollection);
        }

        /// <summary>
        /// Unsubscribes the specified result of subscribe collection.
        /// </summary>
        /// <param name="resultOfSubscribeCollection">The result of subscribe collection.</param>
        public async Task Unsubscribe(ResultOfSubscribeCollection resultOfSubscribeCollection)
        {
             await this.Request<string>("net.unsubscribe", resultOfSubscribeCollection);
        }

        /// <summary>
        /// Subscribes the collection.
        /// </summary>
        /// <param name="paramsOfWaitForCollection">The parameters of wait for collection.</param>
        /// <returns></returns>
        public async Task<ResultOfSubscribeCollection> SubscribeCollection(ParamsOfSubscribeCollection paramsOfWaitForCollection)
        {
            return await this.Request<ResultOfSubscribeCollection>("net.subscribe_collection", paramsOfWaitForCollection);
        }

        #endregion
    }
}