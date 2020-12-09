# TON.SDK.NET
[TON SDK](https://github.com/tonlabs/TON-SDK) Client library .NET bindings (version 1.0.0)
SDK is implemented in the C# language, using the framework there is .NetStandard 2.1, which makes it possible to develop cross-platform applications. Applications can be desktop, web, mobile. \
*Currently mobile OS is not supported, but support is expected in the modest future.*

## Quick build and test
1. Download the project from github
2. Install [.NET CORE 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
3. In the folder with tests, execute the command **dotnet test**

## Build And Testing with IDE
[Microsoft VisualStudio 2019](https://visualstudio.microsoft.com/ru/downloads/) Windows \
[JetBrain Rider 20.2](https://www.jetbrains.com/rider/)  Windows, Linux, MacOs

## Library
https://github.com/tonlabs/TON-SDK

*a compatible version of the library is included in the project*

## References
[.NetCore 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### References from Nuget (installed automatically)
 - NUnit Test SDK
 - Newtonsoft.Json.Net
 
## Supported OS
 - **Windows x64** (tested in the Windows 10 x64, VisualStudio 2019)
 - **Linux x64**  (tested in the Ubuntu 20.04 x64, JetBrains Rider 20.2)
 - **MacOs x64**  (tested in the macOS Catalina 10.15.6, JetBrains Rider 20.2)

## Nuget
**Install-Package Net.Ton.Sdk -Version 1.0.6**

 ## Code Example
 ```csharp
public async Task ExampleClient()
{
    using var client = new TonClient(new ClientConfig("net.ton.dev"));
    var result = await client.Client.GetVersion();
    Console.WriteLine(result.Version);
}  

public async Task ExampleCrypto()
{
    using var client = new TonClient(new ClientConfig("net.ton.dev"));
    var keyPair = await client.Crypto.GenerateRandomSignKeys();
    Console.WriteLine("public:{0}",keyPair.Public);
    Console.WriteLine("secret:{0}", keyPair.Secret);
}

public async Task ExampleNet()
{
    using var client = new TonClient(new ClientConfig("net.ton.dev"));
    var result = await client.Net.QueryCollection(new ParamsOfQueryCollection
    {
        Collection = "accounts",
        Result = "id balance",
        Limit = 1
    });

    var id = result.Result[0]["id"];
    var balance = result.Result[0]["balance"];
    Console.WriteLine("id={0}, balance={1}", id, balance);
}

 ```
[see more examples in tests](https://github.com/staszx/Ton.Sdk/tree/main/Ton.Sdk.Tests)
           
