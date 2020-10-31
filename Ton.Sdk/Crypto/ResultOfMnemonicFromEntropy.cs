namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfMnemonicFromEntropy
    {
        #region Properties

        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        #endregion
    }
}