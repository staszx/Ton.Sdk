namespace Ton.Sdk.BOC
{
    using Newtonsoft.Json;


    /// <summary>
    /// The result of get code from tvc
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_code_from_tvc
    /// </summary>
    public class ResultOfGetCodeFromTvc
    {
        #region Properties

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonProperty("code")] 
        public string Code { get; set; }

        #endregion
    }
}