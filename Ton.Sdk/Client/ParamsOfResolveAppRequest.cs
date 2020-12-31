namespace Ton.Sdk.Client
{
    using Newtonsoft.Json;

    public class ParamsOfResolveAppRequest
    {
        #region Properties

        [JsonProperty("app_request_id")] public uint AppRequestId { get; set; }

        [JsonProperty("result")] public AppRequestResult Result { get; set; }

        #endregion
    }
}