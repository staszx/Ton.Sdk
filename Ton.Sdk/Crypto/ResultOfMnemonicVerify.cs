namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Mnemonic Verify
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfMnemonicVerify
    /// </summary>
    public class ResultOfMnemonicVerify
    {
        #region Properties

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        #endregion
    }
}