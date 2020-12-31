namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfSigningBoxSign
    {
        #region Properties

        [JsonProperty("signing_box")] public int SigningBox { get; set; }

        [JsonProperty("unsigned")] public string Unsigned { get; set; }

        #endregion
    }
}