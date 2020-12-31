namespace Ton.Sdk.Crypto
{
using Newtonsoft.Json;
public class ResultOfSigningBoxSign
{
[JsonProperty("signature")]
public string Signature {get;set;}
}
}