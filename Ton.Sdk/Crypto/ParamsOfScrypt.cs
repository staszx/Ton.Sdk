namespace Ton.Sdk.Crypto
{
    using Newtonsoft.Json;

    public class ParamsOfScrypt
    {
        #region Properties

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }

        [JsonProperty("log_n")]
        public uint LogN { get; set; }

        [JsonProperty("r")]
        public uint R { get; set; }

        [JsonProperty("p")]
        public uint P { get; set; }

        [JsonProperty("dk_len")]
        public uint DkLen { get; set; }

        #endregion
    }
}