namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of Mnemonic From Entropy
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfMnemonicFromEntropy
    /// </summary>
    public class ParamsOfMnemonicFromEntropy
    {
        #region Properties

        /// <summary>
        /// Gets or sets the entropy.
        /// </summary>
        /// <value>
        /// The entropy.
        /// </value>
        [JsonProperty("entropy")]
        public string Entropy { get; set; }

        /// <summary>
        /// Gets or sets the dictionary.
        /// </summary>
        /// <value>
        /// The dictionary.
        /// </value>
        [JsonProperty("dictionary")]
        public uint? Dictionary { get; set; }

        /// <summary>
        /// Gets or sets the word count.
        /// </summary>
        /// <value>
        /// The word count.
        /// </value>
        [JsonProperty("word_count")]
        public uint? WordCount { get; set; }

        #endregion
    }
}