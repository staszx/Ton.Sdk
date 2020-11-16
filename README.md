# TON.SDK.NET
TON SDK Client library .NET bindings (version 1.0.0)
For MS VisualStudio 2019 (.NetStandard 2.1)

## Library
https://github.com/tonlabs/TON-SDK

## References
[.NetCore 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### References from Nuget (installed automatically)
 - NUnit Test SDK
 - Newtonsoft.Json.Net
 
## Supported OS
 - Windows x64
 - Linux x64
 - Android x64
 
 ## Code Example
 ```csharp
public async Task Example()
{
    using var client = new TonClient(new ClientConfig("net.ton.dev"));
    var result = await client.Client.GetVersion();
    Console.WriteLine(result.Version);
}        
 ```
[see more examples in tests](https://github.com/staszx/Ton.Sdk/tree/main/Ton.Sdk.Tests)
           
