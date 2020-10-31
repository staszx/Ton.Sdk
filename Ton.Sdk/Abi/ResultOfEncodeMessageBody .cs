namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of encoded message body
    /// </summary>
    public class ResultOfEncodeMessageBody
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the body.
        /// </summary>
        /// <value>
        ///     The body.
        /// </value>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        ///     Gets or sets the data to sign.
        /// </summary>
        /// <value>
        ///     The data to sign.
        /// </value>
        [JsonProperty("data_to_sign")]
        public string DataToSign { get; set; }

        #endregion
    }
}