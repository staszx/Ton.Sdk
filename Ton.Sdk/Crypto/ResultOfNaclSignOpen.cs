namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Nacl Sign Open
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfNaclSignOpen
    /// </summary>
    public class ResultOfNaclSignOpen
    {
        #region Properties

        [JsonProperty("unsigned")]
        public string Unsigned { get; set; }

        #endregion
    }
}