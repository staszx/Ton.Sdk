namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfNaclBoxOpen
    {
        #region Properties

        [JsonProperty("decrypted")]
        public string Decrypted { get; set; }

        #endregion
    }
}