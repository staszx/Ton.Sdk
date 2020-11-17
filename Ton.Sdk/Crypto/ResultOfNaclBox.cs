namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Result Of Nacl Box
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ResultOfNaclBox
    /// </summary>
    public class ResultOfNaclBox
    {
        #region Properties

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        #endregion
    }
}