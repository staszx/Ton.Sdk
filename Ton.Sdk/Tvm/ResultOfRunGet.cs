namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;

    /// <summary>
    /// The result of run get
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class ResultOfRunGet
    {

        #region Properties

        /// <summary>
        /// Gets or sets the output.
        /// </summary>
        /// <value>
        /// The output.
        /// </value>
        [JsonProperty("output")] 
        public object Output { get; set; }

        #endregion
    }
}