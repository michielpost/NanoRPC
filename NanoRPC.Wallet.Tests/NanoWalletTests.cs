using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet.Tests
{
  [TestClass]
  public class NanoWalletTests
  {
    private static NanoWallet wallet;
    private const string seed = "31310173082E376A949D1297660ACD7BF30A4F5DBAA16C4F545483FD511DCA32";
    private const string representative = "nano_34zuxqdsucurhjrmpc4aixzbgaa4wjzz6bn5ryn56emc9tmd3pnxjoxfzyb6";


    [ClassInitialize]
    public static void Start(TestContext context)
    {
      var api = NanoClient.GetClient(Configuration.BaseUrl);
      var manager = new NanoAccountManager(api, representative, seed);
      wallet = manager.GetNanoWallet(0);
    }


    [TestMethod]
    public async Task GetAccountInfo()
    {
      var result = await wallet.GetAccountInfoAsync();

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Representative);
      Assert.IsNotNull(result.Representative_Block);
    }

    [TestMethod]
    public async Task GetBalance()
    {
      var result = await wallet.GetBalanceAsync();

      Assert.IsNotNull(result);

      Assert.IsNotNull(result.Balance);
      Assert.IsTrue(result.Balance.Raw > new NanoAmount().Raw);

      Assert.IsNotNull(result.Pending);
      Assert.AreEqual(new NanoAmount(0, AmountBase.Nano), result.Pending);
    }

    [TestMethod]
    public async Task GetTransactions()
    {
      var result = await wallet.GetTransactionsAsync();

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.History);
      Assert.AreEqual(1, result.History.Count);
    }

    [TestMethod]
    public async Task GetPendingTransactions()
    {
      var result = await wallet.GetPendingTransactionsAsync();

      Assert.IsNotNull(result);
      Assert.AreEqual(0, result.Blocks.Count);
    }


    [TestMethod]
    public void CreateFirstTransactionBlock()
    {
      var signResult = wallet.CreateAndSignBlock(new NanoAmount(1, AmountBase.Nano), "46111F2C65ADAD3C99E0E4C9FB47C604DCF9446C89A036740EB22B46952AE595");

      Assert.IsNotNull(signResult);
      //Assert.AreEqual("32FFAD06E23C063A14FD3D3BB95A3DDA70A89CCCC814C33B8164DAA47082F64C", block.Hash);
      Assert.AreEqual(representative, signResult.block.Representative);

    }

    
  }
}
