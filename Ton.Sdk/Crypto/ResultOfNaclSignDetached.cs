namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfNaclSignDetached
    {
        #region Properties

        [JsonProperty("signature")]
        public string Signature { get; set; }

        #endregion
    }
}