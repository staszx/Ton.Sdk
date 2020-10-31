namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfMnemonicFromRandom
    {
        #region Properties

        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        #endregion
    }
}