namespace Ton.Sdk.Net
{
    using Newtonsoft.Json;

    public class RegisteredIterator
    {
        [JsonProperty("handle")]
        public uint Handle { get; set; }
    }
}