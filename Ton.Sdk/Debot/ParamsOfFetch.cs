namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfFetch
    {
        #region Properties

        [JsonProperty("address")] 
        public string Address { get; set; }

        #endregion
    }
}