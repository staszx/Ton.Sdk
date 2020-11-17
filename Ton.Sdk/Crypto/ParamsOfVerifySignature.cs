namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Verify Signature
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfVerifySignature
    /// </summary>
    public class ParamsOfVerifySignature
    {
        #region Properties

        [JsonProperty("signed")]
        public string Signed { get; set; }

        [JsonProperty("public")]
        public string Public { get; set; }

        #endregion
    }
}