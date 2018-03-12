using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class UncheckedBlocksTests
  {
    private INanoRPC _client;

    public UncheckedBlocksTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task Unchecked()
    {
      var result = await _client.Unchecked(new UncheckedRequest());

      Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task UncheckedClear()
    {
      var result = await _client.UncheckedClear(new UncheckedClearRequest());

      Assert.IsNotNull(result);
    }
  }
}
