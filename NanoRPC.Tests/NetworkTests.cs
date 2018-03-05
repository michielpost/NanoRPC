using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class NetworkTests
  {
    private INanoRPC _client;

    public NetworkTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task AvailableSupply()
    {
      var result = await _client.AvailableSupply(new AvailableSupplyRequest());

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Available);
      Assert.AreEqual("133248289218203497353846153999000000001", result.Available);
    }

  }
}
