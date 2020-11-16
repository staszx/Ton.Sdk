namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public class ParamsOfFactorize
    {
        #region Properties

        /// <summary>
        /// Gets or sets the composite.
        /// </summary>
        /// <value>
        /// The composite.
        /// </value>
        [JsonProperty("composite")]
        public string Composite { get; set; }

        #endregion
    }
}