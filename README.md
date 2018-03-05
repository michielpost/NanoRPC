
[![Build status](https://ci.appveyor.com/api/projects/status/k209wg02y7adyp1j/branch/master?svg=true)](https://ci.appveyor.com/project/michielpost/nanorpc/branch/master)

# NanoRPC

Nano RPC Client library in C#

Easily communicatie with a Nano Node using C#

## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [NanoRPC on NuGet](https://nuget.org/packages/NanoRPC).

## Example Usage

```cs
var client = NanoClient.GetClient("http://url_to_nano_node:port");

var balanceResult = await _client.AccountBalance(new AccountBalanceRequest() { Account = "xrb_1cyca8x1u4bdi3m6aqjx1ouwayrnais7aucc33w9zxdtrwqaoxdt8yfdzm94" });
```

## Supported RPC methods
All RPC methods are supported.  
List of RPC methods: https://github.com/nanocurrency/raiblocks/wiki/RPC-protocol

Please create an issue if something is not working as expected. Pull Requests are also welcome!

## License

NanoRPC is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [LICENSE](https://github.com/michielpost/NanoRPC/blob/master/LICENSE) for more information.

## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

### Open Source Project Credits
This library use RestEase https://github.com/canton7/RestEase
