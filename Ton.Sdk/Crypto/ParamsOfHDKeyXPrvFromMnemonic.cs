namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of HD Key XPrv From Mnemonic
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyXPrvFromMnemonic
    /// </summary>
    public class ParamsOfHDKeyXPrvFromMnemonic
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