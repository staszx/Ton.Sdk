namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

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