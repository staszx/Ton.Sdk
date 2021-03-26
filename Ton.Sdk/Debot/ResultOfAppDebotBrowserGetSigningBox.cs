namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class ResultOfAppDebotBrowserGetSigningBox
    {
        #region Properties

        [JsonProperty("signing_box")]
        public int SigningBox { get; set; }

        #endregion
    }
}