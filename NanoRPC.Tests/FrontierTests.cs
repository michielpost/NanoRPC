using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class FrontierTests
  {
    private INanoRPC _client;

    public FrontierTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task FrontierCount()
    {
      var result = await _client.FrontierCount(new FrontierCountRequest());

      Assert.IsNotNull(result);
    }
  }
}
