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

    private string _account = "xrb_3poi3yur6n5ew65x5bmh7pre67reuj4mahwmcqe649abugnsmb97qrdfyk61";

    public FrontiersTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task KeyCreate()
    {
      var result = await _client.Frontiers(new FrontiersRequest() { Account = _account, Count = "10" });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Frontiers);
    }

  }
}
