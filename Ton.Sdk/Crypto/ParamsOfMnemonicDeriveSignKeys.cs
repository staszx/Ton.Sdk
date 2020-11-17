namespace Ton.Sdk.Crypto
{
    using Client;
    using Newtonsoft.Json;
    /// <summary>    public class ParamsOfMnemonicDeriveSignKeys
    Params Of HD Key XPrv From Mnemonic
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyXPrvFromMnemonic
    /// </summary>
    public class ParamsOfMnemonicDeriveSignKeys
    {
        #region Properties

        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("dictionary")]
        public MnemonicDictionary? Dictionary { get; set; }

        [JsonProperty("word_count")]
        public uint? WordCount { get; set; }

        #endregion
    }
}