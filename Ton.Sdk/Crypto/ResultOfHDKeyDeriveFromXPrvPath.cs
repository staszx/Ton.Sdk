namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfHDKeyDeriveFromXPrvPath
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        #endregion
    }
}