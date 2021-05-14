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

        /// <summary>
        /// Suspends this instance.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#suspend
        /// </summary>
        public async Task Suspend()
        {
             await this.Request<string>("net.suspend");
        }

        /// <summary>
        /// Resumes this instance.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#resume
        /// </summary>
        public async Task Resume()
        {
            await this.Request<string>("net.resume");
        }

        /// <summary>
        /// Finds the last shard block.
        /// </summary>
        /// <param name="paramsOfFindLastShardBlock">The parameters of find last shard block.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#find_last_shard_block
        /// <returns></returns>
        public async Task<ResultOfFindLastShardBlock> FindLastShardBlock(ParamsOfFindLastShardBlock paramsOfFindLastShardBlock)
        {
           return await this.Request<ResultOfFindLastShardBlock>("net.find_last_shard_block", paramsOfFindLastShardBlock);
        }

        /// <summary>
        /// Fetches the end points.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#fetch_endpoints
        /// </summary>
        /// <returns></returns>
        public async Task<EndpointsSet> FetchEndPoints()
        {
            return await this.Request<EndpointsSet>("net.fetch_endpoints");
        }

        /// <summary>
        /// Sets the end points.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#set_endpoints
        /// </summary>
        /// <param name="endpointsSet">The endpoints set.</param>
        public async Task SetEndPoints(EndpointsSet endpointsSet)
        {
             await this.Request<object>("net.set_endpoints", endpointsSet);
        }

        /// <summary>
        /// Queries the counterparties.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_net.md#query_counterparties
        /// </summary>
        /// <param name="paramsOfQueryCounterparties">The parameters of query counterparties.</param>
        /// <returns></returns>
        public async Task<ResultOfQueryCollection> QueryCounterparties(ParamsOfQueryCounterparties paramsOfQueryCounterparties)
        {
            return await this.Request<ResultOfQueryCollection>("net.query_counterparties", paramsOfQueryCounterparties);
        }

        #endregion
    }
}