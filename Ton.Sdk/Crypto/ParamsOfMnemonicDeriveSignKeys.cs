namespace Ton.Sdk.Crypto
{
    using Client;
    using Newtonsoft.Json;

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