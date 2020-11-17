namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///     The Params Of Mnemonic Words
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfMnemonicWords
    /// </summary>
    public class ParamsOfMnemonicWords
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

        #endregion
    }
}