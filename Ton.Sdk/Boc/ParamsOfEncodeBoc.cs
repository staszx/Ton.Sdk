using System;
using System.Collections.Generic;
using System.Text;

namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#paramsofencodeboc
    /// </summary>
    public class ParamsOfEncodeBoc
    {
        [JsonProperty("builder")]
        public BuilderOp[] Builder { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("boc_cache")]
        public BocCacheType BocCache { get; set; }
    }
}
