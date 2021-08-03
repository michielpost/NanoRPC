using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet.Tests
{
  [TestClass]
  public class NanoAccountManagerTests
  {
    private NanoAccountManager manager;
    private const string seed = "31310173082E376A949D1297660ACD7BF30A4F5DBAA16C4F545483FD511DCA32";
    private const string representative = "nano_34zuxqdsucurhjrmpc4aixzbgaa4wjzz6bn5ryn56emc9tmd3pnxjoxfzyb6";

    public NanoAccountManagerTests()
    {
      var api = NanoClient.GetClient(Configuration.BaseUrl);
      manager = new NanoAccountManager(api, representative, seed);
    }

    private static string RandomHexString()
    {
      // 64 character precision or 256-bits
      Random rdm = new Random();
      string hexValue = string.Empty;
      int num;

      for (int i = 0; i < 8; i++)
      {
        num = rdm.Next(0, int.MaxValue);
        hexValue += num.ToString("X8");
      }

      return hexValue.ToUpperInvariant();
    }

    [TestMethod]
    public void GetPrivateKey()
    {
      var privateKey = manager.GetPrivateKey(0);
      Assert.AreEqual("8F0CEB57251F60F54F5E3AFED5AD9D7323FD1EE5D0A05825EAA4E746520CE0C4", privateKey);

      var publicKey = manager.GetPublicKey(privateKey);
      Assert.AreEqual("2B1D982BCE2364E2D7C78190B7CD627CBB619BC6B51C9092E8661757C9D21DF9", publicKey);

      var address = manager.GetAddress(publicKey);
      Assert.AreEqual("nano_1crxm1owwau6wddwh1eipz8p6z7ue8fwffawk4bgisiqcz6x69hsepgtgj31", address);

      var reversePublicKey = BlockSigner.GetPublicKey(address);
      Assert.AreEqual(publicKey, reversePublicKey);
    }


    [TestMethod]
    public void GetAddress()
    {
      var result = manager.GetAddress(0);
      var wallet = manager.GetNanoWallet(0);


      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Account);
      Assert.AreEqual("nano_1crxm1owwau6wddwh1eipz8p6z7ue8fwffawk4bgisiqcz6x69hsepgtgj31", result.Account);
      Assert.AreEqual(wallet.Account, result.Account);
    }

    [TestMethod]
    public void GetAddressAtIndex()
    {
      var result = manager.GetAddress(3);
      var wallet = manager.GetNanoWallet(3);

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Account);
      Assert.AreEqual("nano_1kt44ok7q5wjmrbsiynk4otyrtkucnbmd4tzwo87xg4xduwp4kgok4jx4yu7", result.Account);
      Assert.AreEqual(wallet.Account, result.Account);

    }


    [TestMethod]
    public async Task GetPendingTransactionsAll()
    {
      var result = await manager.GetPendingTransactionsAsync(0..3);

      Assert.IsNotNull(result);
      Assert.AreEqual(3, result.Blocks.Count);

    }

    [TestMethod]
    public async Task GetBalances()
    {
      var result = await manager.GetBalancesAsync(0..3);

      Assert.IsNotNull(result);
      Assert.AreEqual(3, result.Balances.Count);

    }



  }
}
