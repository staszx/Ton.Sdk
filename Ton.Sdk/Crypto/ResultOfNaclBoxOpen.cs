namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Nacl Box Open
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfNaclBoxOpen
    /// </summary>
    public class ResultOfNaclBoxOpen
    {
        #region Properties

        /// <summary>
        /// Gets or sets the decrypted.
        /// </summary>
        /// <value>
        /// The decrypted.
        /// </value>
        [JsonProperty("decrypted")]
        public string Decrypted { get; set; }

        #endregion
    }
}