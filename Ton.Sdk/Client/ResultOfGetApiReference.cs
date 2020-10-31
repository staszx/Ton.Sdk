namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    /// The result of api reference
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_client.md#get_api_reference
    /// </summary>
    public class ResultOfGetApiReference
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the API.
        /// </summary>
        /// <value>
        ///     The API.
        /// </value>
        [JsonProperty("api")]
        public object Api { get; set; }

        #endregion
    }
}