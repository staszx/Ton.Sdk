namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfHDKeyXPrvFromMnemonic
    {
        #region Properties

        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        [JsonProperty("dictionary")]
        public uint? Dictionary { get; set; }

        [JsonProperty("word_count")]
        public uint? WordCount { get; set; }

        #endregion
    }
}