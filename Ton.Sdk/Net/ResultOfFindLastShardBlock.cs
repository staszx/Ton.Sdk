namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class ResultOfFindLastShardBlock
    {
        #region Properties

        [JsonProperty("block_id")] 
        public string BlockId { get; set; }

        #endregion
    }
}