namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Hash
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfHash
    /// </summary>
    public class ResultOfHash
    {
        #region Properties

        [JsonProperty("hash")]
        public string Hash { get; set; }

        #endregion
    }
}