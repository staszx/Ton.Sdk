namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfHDKeyDeriveFromXPrvPath
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        #endregion
    }
}