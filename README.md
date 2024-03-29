<img src="https://raw.githubusercontent.com/michielpost/NanoRPC/master/logo.jpg" height="150" width="150">

[![Build .NET](https://github.com/michielpost/NanoRPC/actions/workflows/build.yml/badge.svg)](https://github.com/michielpost/NanoRPC/actions/workflows/build.yml)

# NanoRPC

Nano RPC Client and Nano Wallet library in C#

Easily communicate with a Nano Node using C#
This library includes a programmable wallet to easily receive and send Nano. It can be used in ASP.Net, Desktop apps and also in the browser using Blazor WebAssembly.

Donation address: nano_14ezmbmoj5zqzoj7g99bec1rfr7woe1d7bsa87wmsbfpt4u4mnur8183oqtm

**[Live Blazor WebAssembly Wallet Demo](https://michielpost.github.io/NanoRPC/)**

## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [NanoRPC on NuGet](https://nuget.org/packages/NanoRPC).

## Example Usage

```cs
var client = NanoClient.GetClient("http://url_to_nano_node:port");

var balanceResult = await _client.AccountBalance(new AccountBalanceRequest() { Account = "xrb_1cyca8x1u4bdi3m6aqjx1ouwayrnais7aucc33w9zxdtrwqaoxdt8yfdzm94" });
```

### Wallet
```cs
var client = NanoClient.GetClient(A"http://url_to_nano_node:port");
var manager = new NanoAccountManager(client, "nano_default_representative_address", "HEX SEED STRING");
var wallet = manager.GetNanoWallet(i);

var balance = await wallet.GetBalanceAsync();

//Send Nano
await wallet.SendNano("To Address", amount);
```

## Supported RPC methods
All RPC methods are supported.  
List of RPC methods: https://docs.nano.org/commands/rpc-protocol/

Please create an issue if something is not working as expected. Pull Requests are also welcome!

## License

NanoRPC is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [LICENSE](https://github.com/michielpost/NanoRPC/blob/master/LICENSE) for more information.

## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

### Open Source Project Credits
This library uses RestEase https://github.com/canton7/RestEase
