using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class FrontiersTests
  {
    private INanoRPC _client;

    public FrontiersTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task Frontiers()
    {
      var result = await _client.Frontiers(new FrontiersRequest() { Account = "nano_1114g5pesiopr4r5jsdhzgiuc19ed9o881b3d5714w4pd49g3iohdp59p97d", Count = 10 });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Frontiers);
    }

    [TestMethod]
    public async Task FrontierCount()
    {
      var result = await _client.FrontierCount(new FrontierCountRequest());

      Assert.IsNotNull(result);
    }
  }
}
