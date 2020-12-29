namespace Ton.Sdk.Debot
{
    using System.Threading.Tasks;

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
        ///     Starts the specified parameters of start.
        /// </summary>
        /// <param name="paramsOfStart">The parameters of start.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#start
        /// <returns></returns>
        public async Task<RegisteredDebot> Start(ParamsOfStart paramsOfStart)
        {
            return await this.Request<RegisteredDebot>("debot.start", paramsOfStart);
        }

        /// <summary>
        ///     Fetches the specified parameters of fetch.
        /// </summary>
        /// <param name="paramsOfFetch">The parameters of fetch.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_debot.md#fetch
        /// <returns></returns>
        public async Task<RegisteredDebot> Fetch(ParamsOfFetch paramsOfFetch)
        {
            return await this.Request<RegisteredDebot>("debot.fetch", paramsOfFetch);
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

        #endregion
    }
}