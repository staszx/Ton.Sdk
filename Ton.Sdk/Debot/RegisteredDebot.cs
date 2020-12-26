namespace Ton.Sdk.Debot
{
    using Newtonsoft.Json;

    public class RegisteredDebot
    {
        #region Properties

        [JsonProperty("debot_handle")] 
        public int DebotHandle { get; set; }

        #endregion
    }
}