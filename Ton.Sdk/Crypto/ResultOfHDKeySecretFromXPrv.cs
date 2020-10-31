namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfHDKeySecretFromXPrv
    {
        #region Properties

        [JsonProperty("secret")]
        public string Secret { get; set; }

        #endregion
    }
}