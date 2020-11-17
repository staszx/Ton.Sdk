namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Convert Public Key To Ton Safe Format
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfConvertPublicKeyToTonSafeFormat
    /// </summary>
    public class ResultOfConvertPublicKeyToTonSafeFormat
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ton public key.
        /// </summary>
        /// <value>
        /// The ton public key.
        /// </value>
        [JsonProperty("ton_public_key")]
        public string TonPublicKey { get; set; }

        #endregion
    }
}