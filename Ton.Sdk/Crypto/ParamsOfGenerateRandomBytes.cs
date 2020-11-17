namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    ///The Params Of Generate Random Bytes
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ParamsOfGenerateRandomBytes
    /// </summary>
    public class ParamsOfGenerateRandomBytes
    {
        #region Properties

        [JsonProperty("length")]
        public uint Length { get; set; }

        #endregion
    }
}