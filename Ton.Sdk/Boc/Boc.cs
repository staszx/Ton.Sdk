namespace Ton.Sdk.Boc
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The boc
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#module-boc
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Boc : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Boc" /> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        internal Boc(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Parses the message.
        /// </summary>
        /// <param name="paramsOfParse">The parameters of parse.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_message
        /// <returns>ResultOfParse</returns>
        public async Task<ResultOfParse> ParseMessage(ParamsOfParse paramsOfParse)
        {
            return await this.Request<ResultOfParse>("boc.parse_message", paramsOfParse);
        }

        /// <summary>
        ///     Parses the transaction.
        /// </summary>
        /// <param name="paramsOfParse">The parameters of parse.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_transaction
        /// <returns>ResultOfParse</returns>
        public async Task<ResultOfParse> ParseTransaction(ParamsOfParse paramsOfParse)
        {
            return await this.Request<ResultOfParse>("boc.parse_transaction", paramsOfParse);
        }

        /// <summary>
        ///     Parses the account.
        /// </summary>
        /// <param name="paramsOfParse">The parameters of parse.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_account
        /// <returns>ResultOfParse</returns>
        public async Task<ResultOfParse> ParseAccount(ParamsOfParse paramsOfParse)
        {
            return await this.Request<ResultOfParse>("boc.parse_account", paramsOfParse);
        }

        /// <summary>
        /// Parses the block.
        /// </summary>
        /// <param name="paramsOfParse">The parameters of parse.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#parse_block
        /// <returns>ResultOfParse</returns>
        public async Task<ResultOfParse> ParseBlock(ParamsOfParse paramsOfParse)
        {
            return await this.Request<ResultOfParse>("boc.parse_block", paramsOfParse);
        }

        /// <summary>
        ///     Parses the block.
        /// </summary>
        /// <param name="paramsOfGetBlockchainConfig">The parameters of get blockchain configuration.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_blockchain_config
        /// <returns>ResultOfGetBlockchainConfig</returns>
        public async Task<ResultOfGetBlockchainConfig> GetBlockChainConfig(ParamsOfGetBlockchainConfig paramsOfGetBlockchainConfig)
        {
            return await this.Request<ResultOfGetBlockchainConfig>("boc.get_blockchain_config", paramsOfGetBlockchainConfig);
        }

        #endregion
    }
}