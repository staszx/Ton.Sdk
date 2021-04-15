namespace Ton.Sdk.Debot
{
using Newtonsoft.Json;
public class ResultOfAppDebotBrowserApprove
{
[JsonProperty("approved")]
public bool Approved {get;set;}
}
}