namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;

    /// <summary>
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#paramsofencodeboc
    /// </summary>
    public class ResultOfEncodeBoc
    {
        #region Properties

        [JsonProperty("boc")]
        public string Boc { get; set; }

        #endregion
    }
}