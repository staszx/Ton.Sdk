namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Secret Box
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSecretBox
    /// </summary>
    public class ParamsOfNaclSecretBox
    {
        #region Properties

        [JsonProperty("decrypted")]
        public string Decrypted { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}