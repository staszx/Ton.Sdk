namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Box Open
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclBoxOpen
    /// </summary>
    public class ParamsOfNaclBoxOpen
    {
        #region Properties

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("their_public")]
        public string TheirPublic { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}