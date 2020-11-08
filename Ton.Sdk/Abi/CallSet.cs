namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The CallSet class
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#callset
    /// </summary>
    public class CallSet
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CallSet" /> class.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="header">The header.</param>
        /// <param name="input">The input.</param>
        public CallSet(string functionName, string header, string input)
        {
            this.FunctionName = functionName;
            if (!string.IsNullOrWhiteSpace(header))
            {
                this.Header = new JRaw(header);
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                this.Input = new JRaw(input);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the name of the function.
        /// </summary>
        /// <value>
        ///     The name of the function.
        /// </value>
        [JsonProperty("function_name")]
        public string FunctionName { get; }

        /// <summary>
        ///     Gets or sets the header.
        /// </summary>
        /// <value>
        ///     The header.
        /// </value>
        [JsonProperty("header")]
        public JRaw Header { get; }

        /// <summary>
        ///     Gets or sets the input.
        /// </summary>
        /// <value>
        ///     The input.
        /// </value>
        [JsonProperty("input")]
        public JRaw Input { get; }

        #endregion
    }
}