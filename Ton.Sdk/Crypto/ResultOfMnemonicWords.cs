namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfMnemonicWords
    {
        #region Properties

        [JsonProperty("words")]
        public string Words { get; set; }

        #endregion
    }
}