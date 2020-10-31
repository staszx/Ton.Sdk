namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

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