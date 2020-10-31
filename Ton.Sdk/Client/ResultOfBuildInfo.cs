namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of build info
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#build_info
    /// </summary>
    public class ResultOfBuildInfo
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the build information.
        /// </summary>
        /// <value>
        ///     The build information.
        /// </value>
        [JsonProperty("build_info")]
        public object BuildInfo { get; set; }

        #endregion
    }
}