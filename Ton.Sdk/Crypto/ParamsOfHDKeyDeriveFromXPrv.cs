namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfHDKeyDeriveFromXPrv
    {
        #region Properties

        [JsonProperty("xprv")]
        public string Xprv { get; set; }

        [JsonProperty("child_index")]
        public uint ChildIndex { get; set; }

        [JsonProperty("hardened")]
        public bool Hardened { get; set; }

        #endregion
    }
}