using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class BootstrapTests
  {
    private INanoRPC _client;

    public BootstrapTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task BootstrapAny()
    {
      var result = await _client.BootstrapAny(new BootstrapAnyRequest());

      Assert.IsNotNull(result);
    }
  }
}
