using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class BlocksTests
  {
    private INanoRPC _client;

    public BlocksTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task BlockCount()
    {
      var result = await _client.BlockCount(new BlockCountRequest());

      Assert.IsNotNull(result);
    }

  }
}
