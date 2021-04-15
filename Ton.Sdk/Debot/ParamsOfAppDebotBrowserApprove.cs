namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ParamsOfAppDebotBrowserApprove
    {
        #region Properties

        [JsonProperty("activity")]
        public DebotActivity Activity { get; set; }

        #endregion
    }
}