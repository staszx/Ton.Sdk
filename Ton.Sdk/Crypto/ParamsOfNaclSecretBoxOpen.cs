namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Nacl Secret Box Open
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfNaclSecretBoxOpen
    /// </summary>
    public class ParamsOfNaclSecretBoxOpen
    {
        #region Properties

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}