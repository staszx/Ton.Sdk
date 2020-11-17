namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Params Of Ton Crc16
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfTonCrc16
    /// </summary>
    public class ParamsOfTonCrc16
    {
        #region Properties

        [JsonProperty("data")]
        public string Data { get; set; }

        #endregion
    }
}