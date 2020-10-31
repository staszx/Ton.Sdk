namespace Ton.Sdk
{
    using System;
    using System.Threading.Tasks;
    using Client;
    using Request;

    /// <summary>
    ///     The client
    /// </summary>
    public sealed class TonClient : IDisposable
    {
        #region Fields

        /// <summary>
        ///     The request library
        /// </summary>
        private readonly RequestLib requestLib;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TonClient" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public TonClient(ClientConfig config)
        {
            this.requestLib = new RequestLib(config);
            this.Utils = new Utils.Utils(this);
            this.Abi = new Abi.Abi(this);
            this.Tvm = new Tvm.Tvm(this);
            this.Client = new Client.Client(this);
            this.Net = new Net.Net(this);
            this.Processing = new Processing.Processing(this);
            this.Crypto = new Crypto.Crypto(this);
            this.Boc = new Boc.Boc(this);
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the utils.
        /// </summary>
        /// <value>
        ///     The utils.
        /// </value>
        public Utils.Utils Utils { get; }

        /// <summary>
        ///     Gets the abi.
        /// </summary>
        /// <value>
        ///     The abi.
        /// </value>
        public Abi.Abi Abi { get; }

        /// <summary>
        ///     Gets the TVM.
        /// </summary>
        /// <value>
        ///     The TVM.
        /// </value>
        public Tvm.Tvm Tvm { get; }

        /// <summary>
        ///     Gets the client.
        /// </summary>
        /// <value>
        ///     The client.
        /// </value>
        public Client.Client Client { get; }

        /// <summary>
        ///     Gets the net.
        /// </summary>
        /// <value>
        ///     The net.
        /// </value>
        public Net.Net Net { get; }

        /// <summary>
        ///     Gets the processing.
        /// </summary>
        /// <value>
        ///     The processing.
        /// </value>
        public Processing.Processing Processing { get; }

        /// <summary>
        ///     Gets the crypto.
        /// </summary>
        /// <value>
        ///     The crypto.
        /// </value>
        public Crypto.Crypto Crypto { get; }

        /// <summary>
        ///     Gets the boc.
        /// </summary>
        /// <value>
        ///     The boc.
        /// </value>
        public Boc.Boc Boc { get; }

        #endregion

        #region Methods

        /// <summary>
        ///     Requests the specified function name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="functionParams">The function parameters.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns></returns>
        internal async Task<T> Request<T>(string functionName, object functionParams = null, ResponseHandler responseHandler = null)
        {
            return await this.requestLib.Request<T>(functionName, functionParams, responseHandler);
        }

        #endregion

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.requestLib?.Dispose();
        }
    }
}