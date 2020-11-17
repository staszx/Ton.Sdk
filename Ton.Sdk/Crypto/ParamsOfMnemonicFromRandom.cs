namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The  Params Of Mnemonic From Random
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfMnemonicFromRandom
    /// </summary>
    public class ParamsOfMnemonicFromRandom
    {
        #region Properties

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