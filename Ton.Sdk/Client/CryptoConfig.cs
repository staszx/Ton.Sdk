namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    /// <summary>
    /// The crypto config
    /// </summary>
    public class CryptoConfig
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the mnemonic dictionary.
        /// </summary>
        /// <value>
        ///     The mnemonic dictionary.
        /// </value>
        [JsonProperty("mnemonic_dictionary")]
        public uint? MnemonicDictionary { get; set; }

        /// <summary>
        ///     Gets or sets the mnemonic word count.
        /// </summary>
        /// <value>
        ///     The mnemonic word count.
        /// </value>
        [JsonProperty("mnemonic_word_count")]
        public uint? MnemonicWordCount { get; set; }

        /// <summary>
        ///     Gets or sets the hdkey derivation path.
        /// </summary>
        /// <value>
        ///     The hdkey derivation path.
        /// </value>
        [JsonProperty("hdkey_derivation_path")]
        public string HdkeyDerivationPath { get; set; }

        /// <summary>
        ///     Gets or sets the hdkey compliant.
        /// </summary>
        /// <value>
        ///     The hdkey compliant.
        /// </value>
        [JsonProperty("hdkey_compliant")]
        public bool? HdkeyCompliant { get; set; }

        #endregion
    }
}