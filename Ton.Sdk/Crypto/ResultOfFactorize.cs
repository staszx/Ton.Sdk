namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Factorize
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfFactorize
    /// </summary>
    public class ResultOfFactorize
    {
        #region Properties

        [JsonProperty("factors")]
        public string[] Factors { get; set; }

        #endregion
    }
}