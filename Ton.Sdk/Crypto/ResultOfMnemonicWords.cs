namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///The Result Of Mnemonic Words
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfMnemonicWords
    /// </summary>
    public class ResultOfMnemonicWords
    {
        #region Properties

        [JsonProperty("words")]
        public string Words { get; set; }

        #endregion
    }
}