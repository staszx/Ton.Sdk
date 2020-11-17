# TON.SDK.NET
TON SDK Client library .NET bindings (version 1.0.0)

## Build And Testing
[Microsoft VisualStudio 2019](https://visualstudio.microsoft.com/ru/downloads/) Windows \
[JetBrain Rider 20.2 Windows](https://www.jetbrains.com/rider/)  Windows, Linux, MacOs

## Library
https://github.com/tonlabs/TON-SDK

## References
[.NetCore 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### References from Nuget (installed automatically)
 - NUnit Test SDK
 - Newtonsoft.Json.Net
 
## Supported OS
 - Windows x64
 - Linux x64
  
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
           
