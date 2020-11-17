namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The  Params Of Mnemonic From Random
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfMnemonicFromRandom
    /// </summary>
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