
[![Build status](https://ci.appveyor.com/api/projects/status/k209wg02y7adyp1j/branch/master?svg=true)](https://ci.appveyor.com/project/michielpost/nanorpc/branch/master)

# NanoRPC

Nano RPC Client library in C#

Easily communicatie with a Nano Node using C#

## Example Usage

```cs
var client = NanoClient.GetClient("http://url_to_nano_node:port");

var balanceResult = await _client.AccountBalance(new AccountBalanceRequest() { Account = "xrb_1cyca8x1u4bdi3m6aqjx1ouwayrnais7aucc33w9zxdtrwqaoxdt8yfdzm94" });
```
