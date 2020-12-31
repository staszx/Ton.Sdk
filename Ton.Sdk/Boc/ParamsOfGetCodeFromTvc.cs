namespace Ton.Sdk.BOC
{
    using Newtonsoft.Json;

    /// <summary>
    /// The params of get code from tvc
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#get_code_from_tvc
    /// </summary>
    public class ParamsOfGetCodeFromTvc
    {
        #region Properties

        [JsonProperty("tvc")] 
        public string Tvc { get; set; }

        #endregion
    }
}