namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfMnemonicWords
    {
        #region Properties

        [JsonProperty("dictionary")]
        public uint? Dictionary { get; set; }

        #endregion
    }
}