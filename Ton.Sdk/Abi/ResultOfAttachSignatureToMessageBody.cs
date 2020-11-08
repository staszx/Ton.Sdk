namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The result of attach signature to message body
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#resultofattachsignaturetomessagebody
    /// </summary>
    public class ResultOfAttachSignatureToMessageBody
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

        #endregion
    }
}