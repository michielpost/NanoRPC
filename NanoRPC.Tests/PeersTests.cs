using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class PeersTests
  {
    private INanoRPC _client;

    public PeersTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task Peers()
    {
      var result = await _client.Peers(new PeersRequest());

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Peers);
    }

  }
}
