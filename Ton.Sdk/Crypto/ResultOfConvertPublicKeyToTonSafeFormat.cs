namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfConvertPublicKeyToTonSafeFormat
    {
        #region Properties

        [JsonProperty("ton_public_key")]
        public string TonPublicKey { get; set; }

        #endregion
    }
}