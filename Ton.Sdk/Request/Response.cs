﻿namespace Ton.Sdk.Request
{
    /// <summary>
    /// The response
    /// </summary>
    internal class Response
    {
        /// <summary>
        /// Gets the request identifier.
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        public uint RequestId { get; }

        /// <summary>
        /// Gets or sets the type of the response.
        /// </summary>
        /// <value>
        /// The type of the response.
        /// </value>
        public ResponseTypes ResponseType { get; set; }

        /// <summary>
        /// Gets or sets the return value.
        /// </summary>
        /// <value>
        /// The return value.
        /// </value>
        public string ReturnValue { get; set; }

        /// <summary>
        /// Gets or sets the response handler.
        /// </summary>
        /// <value>
        /// The response handler.
        /// </value>
        public ResponseHandler ResponseHandler { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="responseHandler">The response handler.</param>
        public Response(uint requestId, ResponseHandler responseHandler)
        {
            this.ResponseType = ResponseTypes.None;
            this.RequestId = requestId;
            this.ResponseHandler = responseHandler;
        }
    }
}