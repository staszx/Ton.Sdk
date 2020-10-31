namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfConvertPublicKeyToTonSafeFormat
    {
        #region Properties

        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        #endregion
    }
}