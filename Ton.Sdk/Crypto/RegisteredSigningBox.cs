namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class RegisteredSigningBox
    {
        #region Properties

        [JsonProperty("handle")] 
        public int Handle { get; set; }

        #endregion
    }
}