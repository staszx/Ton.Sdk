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
    /// The respone handler
    /// </summary>
    /// <param name="request_id">The request identifier.</param>
    /// <param name="params_json">The parameters json.</param>
    /// <param name="response_type">Type of the response.</param>
    /// <param name="finished">if set to <c>true</c> [finished].</param>
    internal delegate void tc_response_handler_t(uint request_id, tc_string_data_t params_json, uint response_type, bool finished);
}