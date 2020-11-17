namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Mnemonic Verify
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfMnemonicVerify
    /// </summary>
    public class ResultOfMnemonicVerify
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ResultOfMnemonicVerify"/> is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if valid; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        #endregion
    }
}