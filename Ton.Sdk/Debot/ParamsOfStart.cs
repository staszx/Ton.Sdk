namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfStart
    {
        #region Properties

        [JsonProperty("address")] 
        public string Address { get; set; }

        #endregion
    }
}