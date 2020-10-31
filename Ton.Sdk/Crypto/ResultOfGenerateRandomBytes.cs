namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfGenerateRandomBytes
    {
        #region Properties

        [JsonProperty("bytes")]
        public string Bytes { get; set; }

        #endregion
    }
}