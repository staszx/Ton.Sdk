namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Box
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclBox
    /// </summary>
    public class ParamsOfNaclBox
    {
        #region Properties

        [JsonProperty("decrypted")]
        public string Decrypted { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("their_public")]
        public string TheirPublic { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}