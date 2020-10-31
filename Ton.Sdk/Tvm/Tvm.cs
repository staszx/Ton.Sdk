namespace Ton.Sdk.Tvm
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The Tvm
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#module-tvm
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Tvm : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Tvm" /> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        internal Tvm(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Encodes the message body.
        /// </summary>
        /// <param name="paramsOfRunExecutor">The parameters of encode message body.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#run_executor
        /// <returns>ResultOfRunExecutor</returns>
        public async Task<ResultOfRunExecutor> RunExecutor(ParamsOfRunExecutor paramsOfRunExecutor)
        {
            return await this.Request<ResultOfRunExecutor>("abi.run_executor", paramsOfRunExecutor);
        }

        /// <summary>
        ///     Runs the TVM.
        /// </summary>
        /// <param name="paramsOfRunTvm">The parameters of run TVM.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#run_tvm
        /// <returns>ResultOfRunTvm</returns>
        public async Task<ResultOfRunTvm> RunTvm(ParamsOfRunTvm paramsOfRunTvm)
        {
            return await this.Request<ResultOfRunTvm>("tvm.run_tvm", paramsOfRunTvm);
        }

        /// <summary>
        ///     Runs the get.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#run_get
        /// </summary>
        /// <param name="paramsOfRunGet">The parameters of run get.</param>
        /// <returns></returns>
        public async Task<ResultOfRunGet> RunGet(ParamsOfRunGet paramsOfRunGet)
        {
            return await this.Request<ResultOfRunGet>("tvm.run_get", paramsOfRunGet);
        }

        #endregion
    }
}