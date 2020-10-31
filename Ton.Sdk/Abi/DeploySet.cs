namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Deploy Set
    /// </summary>
    public class DeploySet
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the TVC.
        /// </summary>
        /// <value>
        ///     The TVC.
        /// </value>
        [JsonProperty("tvc")]
        public string Tvc { get; set; }

        /// <summary>
        ///     Gets or sets the workchain identifier.
        /// </summary>
        /// <value>
        ///     The workchain identifier.
        /// </value>
        [JsonProperty("workchain_id")]
        public int WorkchainId { get; set; }

        /// <summary>
        ///     Gets or sets the inital data.
        /// </summary>
        /// <value>
        ///     The inital data.
        /// </value>
        [JsonProperty("initial_data")]
        public object initalData { get; set; }

        #endregion
    }
}