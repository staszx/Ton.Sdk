namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Nacl Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfNaclSign
    /// </summary>
    public class ResultOfNaclSign
    {
        #region Properties

        /// <summary>
        /// Gets or sets the signed.
        /// </summary>
        /// <value>
        /// The signed.
        /// </value>
        [JsonProperty("signed")]
        public string Signed { get; set; }

        #endregion
    }
}