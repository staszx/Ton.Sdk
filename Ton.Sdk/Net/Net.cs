namespace Ton.Sdk.Net
{
    using System.Threading.Tasks;
    using Request;

    /// <summary>
    ///     The net module
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Net : TonClientModule
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Net"/> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
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
        ///     Waits for collection.
        /// </summary>
        /// <param name="paramsOfWaitForCollection">The parameters of wait for collection.</param>
        /// <returns>ResultOfWaitForCollection</returns>
        public async Task<ResultOfWaitForCollection> WaitForCollection(ParamsOfWaitForCollection paramsOfWaitForCollection)
        {
            return await this.Request<ResultOfWaitForCollection>("net.wait_for_collection", paramsOfWaitForCollection);
        }

        /// <summary>
        ///     Unsubscribes the specified result of subscribe collection.
        /// </summary>
        /// <param name="resultOfSubscribeCollection">The result of subscribe collection.</param>
        public async Task Unsubscribe(ResultOfSubscribeCollection resultOfSubscribeCollection)
        {
            await this.Request<object>("net.unsubscribe", resultOfSubscribeCollection);
        }

        /// <summary>
        ///     Subscribes the collection.
        /// </summary>
        /// <param name="paramsOfSubscribeCollection">The parameters of subscribe collection.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns>ResultOfSubscribeCollection</returns>
        public async Task<ResultOfSubscribeCollection> SubscribeCollection(ParamsOfSubscribeCollection paramsOfSubscribeCollection,
            ResponseHandler responseHandler = null)
        {
            return await this.Request<ResultOfSubscribeCollection>("net.subscribe_collection", paramsOfSubscribeCollection, responseHandler);
        }

        #endregion
    }
}