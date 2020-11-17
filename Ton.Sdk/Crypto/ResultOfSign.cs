namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Sign
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfSign
    /// </summary>
    public class ResultOfSign
    {
        #region Properties

        [JsonProperty("signed")]
        public string Signed { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        #endregion
    }
}