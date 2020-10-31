namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfNaclBoxKeyPairFromSecret
    {
        #region Properties

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}