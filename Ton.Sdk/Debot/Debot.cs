﻿namespace Ton.Sdk.Debot
{
    using System.Threading.Tasks;
    using Request;

    /// <summary>
    ///     The debot module
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Debot : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Debot" /> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        public Debot(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Starts the specified parameters of start.
        /// </summary>
        /// <param name="paramsOfStart">The parameters of start.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns></returns>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#start
        public async Task<RegisteredDebot> Start(ParamsOfStart paramsOfStart,ResponseHandler responseHandler)
        {
            return await this.Request<RegisteredDebot>("debot.start", paramsOfStart, responseHandler);
        }

        /// <summary>
        /// Fetches the specified parameters of fetch.
        /// </summary>
        /// <param name="paramsOfFetch">The parameters of fetch.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns></returns>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#fetch
        public async Task<ResultOfFetch> Fetch(ParamsOfFetch paramsOfFetch, ResponseHandler responseHandler)
        {
            return await this.Request<ResultOfFetch>("debot.fetch", paramsOfFetch, responseHandler);
        }

        /// <summary>
        ///     Executes the specified parameters of execute.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#execute
        /// </summary>
        /// <param name="paramsOfExecute">The parameters of execute.</param>
        public async Task Execute(ParamsOfExecute paramsOfExecute)
        {
            await this.Request<string>("debot.execute", paramsOfExecute);
        }

        /// <summary>
        ///     Removes the specified registered debot.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#remove
        /// </summary>
        /// <param name="registeredDebot">The registered debot.</param>
        public async Task Remove(RegisteredDebot registeredDebot)
        {
            await this.Request<string>("debot.remove", registeredDebot);
        }

        /// <summary>
        /// Removes the specified registered debot.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#send
        /// </summary>
        /// <param name="paramsOfSend">The parameters of send.</param>
        public async Task Send(ParamsOfSend paramsOfSend)
        {
            await this.Request<string>("debot.send", paramsOfSend);
        }

        /// <summary>
        /// Initializes the specified parameters of initialize.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#remarks
        /// </summary>
        /// <param name="paramsOfInit">The parameters of initialize.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns></returns>
        public async Task<RegisteredDebot> Init(ParamsOfInit paramsOfInit, ResponseHandler responseHandler)
        {
            return await this.Request<RegisteredDebot>("debot.init", paramsOfInit, responseHandler);
        }

        #endregion
    }
}