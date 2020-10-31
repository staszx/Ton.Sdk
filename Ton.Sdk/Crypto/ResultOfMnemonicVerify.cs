namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfMnemonicVerify
    {
        #region Properties

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        #endregion
    }
}