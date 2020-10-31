namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    /// The CallSet class
    /// </summary>
    public class CallSet
    {
        /// <summary>
        /// Gets or sets the name of the function.
        /// </summary>
        /// <value>
        /// The name of the function.
        /// </value>
        [JsonProperty("function_name")]
        public string FunctionName { get; set; } = "";

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        [JsonProperty("header")]
        public string Header { get; set; }

        /// <summary>
        /// Gets or sets the input.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        [JsonProperty("input")]
        public string Input { get; set; }
    }
}
