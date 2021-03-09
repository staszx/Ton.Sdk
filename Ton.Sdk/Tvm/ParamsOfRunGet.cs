namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of run get
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#paramsofrunget
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ParamsOfRunGet
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the account.
        /// </summary>
        /// <value>
        ///     The account.
        /// </value>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        ///     Gets or sets the name of the function.
        /// </summary>
        /// <value>
        ///     The name of the function.
        /// </value>
        [JsonProperty("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        ///     Gets or sets the input.
        /// </summary>
        /// <value>
        ///     The input.
        /// </value>
        [JsonProperty("input")]
        public object Input { get; set; }

        /// <summary>
        ///     Gets or sets the execution options.
        /// </summary>
        /// <value>
        ///     The execution options.
        /// </value>
        [JsonProperty("execution_options")]
        public ExecutionOptions ExecutionOptions { get; set; }

        /// <summary>
        /// Gets or sets the tuple list as array.
        /// </summary>
        /// <value>
        /// The tuple list as array.
        /// </value>

        [JsonProperty("tuple_list_as_array")]
        public bool? TupleListAsArray { get; set; }

        #endregion
    }
}