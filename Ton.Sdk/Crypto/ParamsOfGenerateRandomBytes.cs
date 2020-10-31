namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfGenerateRandomBytes
    {
        #region Properties

        [JsonProperty("length")]
        public uint Length { get; set; }

        #endregion
    }
}