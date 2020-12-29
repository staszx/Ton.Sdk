namespace Ton.Sdk.Net
{
using Newtonsoft.Json;
public class EndpointsSet
{
[JsonProperty("endpoints")]
public string[] Endpoints {get;set;}
}
}