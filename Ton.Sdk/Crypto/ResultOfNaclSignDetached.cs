namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Nacl Sign Detached
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfNaclSignDetached
    /// </summary>
    public class ResultOfNaclSignDetached
    {
        #region Properties

        /// <summary>
        /// Gets or sets the signature.
        /// </summary>
        /// <value>
        /// The signature.
        /// </value>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        #endregion
    }
}