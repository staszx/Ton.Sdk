namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfScrypt
    {
        #region Properties

        [JsonProperty("key")]
        public string Key { get; set; }

        #endregion
    }
}