namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfNaclSignKeyPairFromSecret
    {
        #region Properties

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}