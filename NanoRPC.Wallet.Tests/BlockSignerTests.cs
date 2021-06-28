using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet.Tests
{
  [TestClass]
  public class BlockSignerTests
  {
    private static NanoAccountManager manager;
    private static NanoWallet wallet;
    private const string seed = "31310173082E376A949D1297660ACD7BF30A4F5DBAA16C4F545483FD511DCA32";
    private const string representative = "nano_34zuxqdsucurhjrmpc4aixzbgaa4wjzz6bn5ryn56emc9tmd3pnxjoxfzyb6";


    [ClassInitialize]
    public async static Task Start(TestContext context)
    {
      var api = NanoClient.GetClient(Configuration.BaseUrl);
      manager = new NanoAccountManager(api, representative, seed);
      wallet = manager.GetNanoWallet(0);
    }


    [TestMethod]
    public void HashBlock()
    {
      

      string prev = "62F805B8E357B5D24C6CA7FB417A8B0E6F48367B17ECC37167159E155B21249D";
      string link = "7B071FB8EF4819EAF4089F34B4F89189088D90783B39680B9730EEA604511AFF";

      BlockCreateRequest block = new BlockCreateRequest
      {
        Account = wallet.Account,
        Previous = prev,
        Representative = wallet.Account,
        Balance = new NanoAmount(0, AmountBase.Nano),
        Link = link
      };

      var result = BlockSigner.HashBlock(block);

      Assert.AreEqual("1C53399F5B4C501C463A0001616FF71A431CD4B531A09F59E53E0EC2052C0326", result);
    }

    [TestMethod]
    public void SignHash()
    {
      var pk = "8F0CEB57251F60F54F5E3AFED5AD9D7323FD1EE5D0A05825EAA4E746520CE0C4";
      string hash = "1C53399F5B4C501C463A0001616FF71A431CD4B531A09F59E53E0EC2052C0326";

      var result = BlockSigner.SignHash(hash, pk);

      Assert.AreEqual("D4A5BB52AFC8F5C57AE8E4B81EE06063C1BA2B5129BE59E6C0EBFD88751AC3C013AC68AB9D329EE1A141BEC67AB0D0A9B77651D740E92937437EE68CA975DD0C", result);
    }
  }
}
