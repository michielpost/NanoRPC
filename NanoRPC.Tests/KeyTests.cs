using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class KeyTests
  {
    private INanoRPC _client;

    public KeyTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task KeyCreate()
    {
      var result = await _client.KeyCreate(new KeyCreateRequest());

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Account);
      Assert.IsNotNull(result.Public);
      Assert.IsNotNull(result.Private);
    }

  }
}
