namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Scrypt
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfScrypt
    /// </summary>
    public class ResultOfScrypt
    {
        #region Properties

        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}