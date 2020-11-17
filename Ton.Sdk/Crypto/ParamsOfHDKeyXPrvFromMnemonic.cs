namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///The Params Of HD Key XPrv From Mnemonic
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfHDKeyXPrvFromMnemonic
    /// </summary>
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