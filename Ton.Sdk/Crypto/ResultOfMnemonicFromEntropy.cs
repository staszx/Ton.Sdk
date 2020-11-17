namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Mnemonic From Entropy
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfMnemonicFromEntropy
    /// </summary>
    public class ResultOfMnemonicFromEntropy
    {
        #region Properties

        /// <summary>
        /// Gets or sets the phrase.
        /// </summary>
        /// <value>
        /// The phrase.
        /// </value>
        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        #endregion
    }
}