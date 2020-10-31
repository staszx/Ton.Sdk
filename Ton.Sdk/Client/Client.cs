namespace Ton.Sdk.Client
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The client
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#module-client
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Client : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Client" /> class.
        /// </summary>
        /// <param name="tonClient">The request library.</param>
        internal Client(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Gets the API reference.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#get_api_reference
        /// </summary>
        /// <returns>ResultOfGetApiReference</returns>
        public async Task<ResultOfGetApiReference> GetApiReference()
        {
            return await this.Request<ResultOfGetApiReference>("client.get_api_reference");
        }

        /// <summary>
        ///     Gets the version.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#version
        /// </summary>
        /// <returns>ResultOfVersion</returns>
        public async Task<ResultOfVersion> GetVersion()
        {
            return await this.Request<ResultOfVersion>("client.version");
        }

        /// <summary>
        ///     Builds the information.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#build_info
        /// </summary>
        /// <returns>ResultOfBuildInfo</returns>
        public async Task<ResultOfBuildInfo> BuildInfo()
        {
            return await this.Request<ResultOfBuildInfo>("client.build_info");
        }

        #endregion
    }
}