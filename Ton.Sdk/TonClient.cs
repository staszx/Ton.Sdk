namespace Ton.Sdk
{
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;
    using Request;

    /// <summary>
    ///     The client
    /// </summary>
    public class TonClient
    {
        /// <summary>
        ///     The request library
        /// </summary>
        private readonly RequestLib requestLib;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TonClient" /> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public TonClient(string config)
        {
            this.requestLib = new RequestLib(config);
        }

        /// <summary>
        ///     Gets the API reference.
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetApiReference()
        {
            return await this.requestLib.RequestLibrary("client.get_api_reference", "");
        }

        /// <summary>
        ///     Gets the version.
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetVersion()
        {
            return await this.requestLib.RequestLibrary("client.version", "");
        }
    }
}