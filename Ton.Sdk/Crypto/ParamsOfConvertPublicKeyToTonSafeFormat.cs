namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The params of convert public key to ton safe format
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfConvertPublicKeyToTonSafeFormat
    /// </summary>
    public class ParamsOfConvertPublicKeyToTonSafeFormat
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the public key.
        /// </summary>
        /// <value>
        ///     The public key.
        /// </value>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        #endregion
    }
}