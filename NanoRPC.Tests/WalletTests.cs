using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class WalletTests
  {
    private INanoRPC _client;

    public WalletTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task WalletCreate()
    {
      var result = await _client.WalletCreate(new WalletCreateRequest());

      Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task WalletAdd()
    {
      var walletCreate = await _client.WalletCreate(new WalletCreateRequest());

      var result = await _client.WalletAdd(new WalletAddRequest()
      {
        Wallet = walletCreate.Wallet,
        Key = "C969C4C106010366940C23CF2189D4C3F1618D9151E0AC3769FE9CFD07A464FA"
      });

      Assert.IsNotNull(result);
      Assert.AreEqual("xrb_38or3c1qpkt9qkpmgh9asdzg5ogmmtfxqf1hqn79zjzo9a9j5e99txja35su", result.Account);
    }

    [TestMethod]
    public async Task WalletBalances()
    {
      var result = await _client.WalletBalances(new WalletBalancesRequest()
      {
        Wallet = "D5239826AAD5F51C0905C2D5D10A95556F224EF3134507A1F815E0BFD5248754"
      });

      Assert.IsNotNull(result);
    }

  }
}
