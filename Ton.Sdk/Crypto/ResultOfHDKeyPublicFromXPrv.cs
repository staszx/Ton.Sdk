namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfHDKeyPublicFromXPrv
    {
        #region Properties

        [JsonProperty("public")]
        public string Public { get; set; }

        #endregion
    }
}