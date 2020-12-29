namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ParamsOfFindLastShardBlock
    {
        #region Properties

        [JsonProperty("address")] 
        public string Address { get; set; }

        #endregion
    }
}