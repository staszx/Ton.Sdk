namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The result of run get
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#ParamsOfRunGet
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ResultOfRunGet
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the output.
        /// </summary>
        /// <value>
        ///     The output.
        /// </value>
        [JsonProperty("output")]
        public JArray Output { get; set; }

        #endregion
    }
}