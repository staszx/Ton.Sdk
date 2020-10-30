namespace Ton.Sdk
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;
    using Request;

    /// <summary>
    ///     The client
    /// </summary>
    public sealed class TonClient : IDisposable
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
        public async Task<string> GetVersion()
        {
            var result  = await this.requestLib.RequestLibrary("client.version", "");
            return result.GetValue("version").Value<string>();
        }

        /// <summary>
        /// Builds the information.
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> BuildInfo()
        {
            return await this.requestLib.RequestLibrary("client.build_info", "");
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.requestLib?.Dispose();
        }
    }
}