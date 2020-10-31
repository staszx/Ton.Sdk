namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfFactorize
    {
        #region Properties

        [JsonProperty("composite")]
        public string Composite { get; set; }

        #endregion
    }
}