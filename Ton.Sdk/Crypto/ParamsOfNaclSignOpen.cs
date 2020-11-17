namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Sign Open
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSignOpen
    /// </summary>
    public class ParamsOfNaclSignOpen
    {
        #region Properties

        [JsonProperty("signed")]
        public string Signed { get; set; }

        [JsonProperty("public")]
        public string Public { get; set; }

        #endregion
    }
}