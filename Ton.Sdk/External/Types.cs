namespace Ton.Sdk.External
{
    /// <summary>
    /// The external lib string structure
    /// </summary>
    internal struct tc_string_data_t
    {
        /// <summary>
        /// The content
        /// </summary>
        public string content;

        /// <summary>
        /// The length
        /// </summary>
        public uint len;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value
        {
            get => this.content.Substring(0, (int)this.len);
            set
            {
                this.content = value;
                this.len = (uint)value.Length;
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Value;
        }
    }

    /// <summary>
    /// The response types
    /// </summary>
    internal enum tc_response_types_t
    {
        /// <summary>
        /// The tc response success
        /// </summary>
        tc_response_success = 0,

        /// <summary>
        /// The tc response error
        /// </summary>
        tc_response_error = 1,

        /// <summary>
        /// The tc response nop
        /// </summary>
        tc_response_nop = 2,

        /// <summary>
        /// The tc response custom
        /// </summary>
        tc_response_custom = 100,
    };

    /// <summary>
    /// The respone handler
    /// </summary>
    /// <param name="request_id">The request identifier.</param>
    /// <param name="params_json">The parameters json.</param>
    /// <param name="response_type">Type of the response.</param>
    /// <param name="finished">if set to <c>true</c> [finished].</param>
    internal delegate void tc_response_handler_t(uint request_id, tc_string_data_t params_json, uint response_type, bool finished);



    //const requests = new Map<number, Request>();
    //let nextRequestId = 1;
}