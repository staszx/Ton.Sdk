namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfMnemonicFromRandom
    {
        #region Properties

        [JsonProperty("dictionary")]
        public uint? Dictionary { get; set; }

        [JsonProperty("word_count")]
        public uint? WordCount { get; set; }

        #endregion
    }
}