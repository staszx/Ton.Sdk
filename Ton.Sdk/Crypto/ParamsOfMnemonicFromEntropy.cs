namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///  The Params Of Mnemonic From Entropy
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfMnemonicFromEntropy
    /// </summary>
    public class ParamsOfMnemonicFromEntropy
    {
        #region Properties

        [JsonProperty("entropy")]
        public string Entropy { get; set; }

        [JsonProperty("dictionary")]
        public uint? Dictionary { get; set; }

        [JsonProperty("word_count")]
        public uint? WordCount { get; set; }

        #endregion
    }
}