namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ResultOfTonCrc16
    {
        #region Properties

        [JsonProperty("crc")]
        public uint Crc { get; set; }

        #endregion
    }
}