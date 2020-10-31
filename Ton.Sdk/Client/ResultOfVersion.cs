namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of version
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#version
    /// </summary>
    public class ResultOfVersion
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        /// <value>
        ///     The version.
        /// </value>
        [JsonProperty("version")]
        public string Version { get; set; }

        #endregion
    }
}