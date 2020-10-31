namespace Ton.Sdk.Abi
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The State init source
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#stateinitsource
    /// </summary>
    public class StateInitSource
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StateInitSource"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public StateInitSource(MessageSource source)
        {
            this.Type = StateInitSourceType.Message;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateInitSource"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="data">The data.</param>
        /// <param name="library">The library.</param>
        public StateInitSource(string code, string data, string library = null)
        {
            this.Type = StateInitSourceType.StateInit;
            this.Code = code;
            this.Data = data;
            this.Library = library;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateInitSource"/> class.
        /// </summary>
        /// <param name="tvc">The TVC.</param>
        /// <param name="publicKey">The public key.</param>
        /// <param name="stateInit">The state initialize.</param>
        public StateInitSource(string tvc, string publicKey = null, StateInitParams stateInit = null)
        {
            this.Type = StateInitSourceType.Tvc;
            this.Tvc = tvc;
            this.PublicKey = publicKey;
            this.StateInitParams = stateInit;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StateInitSourceType Type { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonProperty("source")]
        public MessageSource Source { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the library.
        /// </summary>
        /// <value>
        /// The library.
        /// </value>
        [JsonProperty("library")]
        public string Library { get; set; }

        /// <summary>
        /// Gets or sets the TVC.
        /// </summary>
        /// <value>
        /// The TVC.
        /// </value>
        [JsonProperty("tvc")]
        public string Tvc { get; set; }

        /// <summary>
        /// Gets or sets the public key.
        /// </summary>
        /// <value>
        /// The public key.
        /// </value>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or sets the state initialize parameters.
        /// </summary>
        /// <value>
        /// The state initialize parameters.
        /// </value>
        [JsonProperty("init_params")]
        public StateInitParams StateInitParams { get; set; }
    }
}