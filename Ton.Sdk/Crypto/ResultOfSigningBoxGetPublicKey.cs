namespace Ton.Sdk.Crypto
{
using Newtonsoft.Json;
public class ResultOfSigningBoxGetPublicKey
{
[JsonProperty("pubkey")]
public string Pubkey {get;set;}
}
}