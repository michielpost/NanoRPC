using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class AccountTests
  {
    private INanoRPC _client;

    public AccountTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }


    [TestMethod]
    public async Task AccountBalanceTest()
    {
      var result = await _client.AccountBalance(new AccountBalanceRequest() { Account = "xrb_3jwrszth46rk1mu7rmb4rhm54us8yg1gw3ipodftqtikf5yqdyr7471nsg1k" });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Balance);
    }
  }
}
