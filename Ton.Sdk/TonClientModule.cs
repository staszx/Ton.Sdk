namespace Ton.Sdk
{
    using System.Threading.Tasks;
    using Request;

    /// <summary>
    ///     The ton client module
    /// </summary>
    public abstract class TonClientModule
    {
        #region Fields

        /// <summary>
        /// The ton client
        /// </summary>
        private readonly TonClient tonClient;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TonClientModule" /> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        internal TonClientModule(TonClient tonClient)
        {
            this.tonClient = tonClient;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Requests the specified function name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="functionParams">The function parameters.</param>
        /// <param name="responseHandler">The response handler.</param>
        /// <returns></returns>
        internal async Task<T> Request<T>(string functionName, object functionParams = null, ResponseHandler responseHandler = null)
        {
            return await this.tonClient.Request<T>(functionName, functionParams, responseHandler);
        }

        #endregion
    }
}