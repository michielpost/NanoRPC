using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class NodeTests
  {
    private INanoRPC _client;

    public NodeTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task Version()
    {
      var result = await _client.Version(new VersionRequest());

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Rpc_Version);
      Assert.AreEqual("1", result.Rpc_Version);
    }

  }
}
