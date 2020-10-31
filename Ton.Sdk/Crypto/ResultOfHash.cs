namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfHash
    {
        #region Properties

        [JsonProperty("hash")]
        public string Hash { get; set; }

        #endregion
    }
}