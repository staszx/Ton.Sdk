namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Mnemonic From Random
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfMnemonicFromRandom
    /// </summary>
    public class ResultOfMnemonicFromRandom
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