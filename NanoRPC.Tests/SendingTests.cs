using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class SendingTests
  {
    private INanoRPC _client;

    public SendingTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }

    [TestMethod]
    public async Task Send()
    {
      var result = await _client.Send(new SendRequest()
      {
        Wallet = "D5239826AAD5F51C0905C2D5D10A95556F224EF3134507A1F815E0BFD5248754",
        Source = "xrb_38or3c1qpkt9qkpmgh9asdzg5ogmmtfxqf1hqn79zjzo9a9j5e99txja35su",
        Destination = "xrb_3ubez7myynk4eigcyyoqndxtek6fcdrmc5gir79zr5m6c6m6dw8ciyb5zxnb",
        Amount = "1",
        Id = "5"
      });

      Assert.IsNotNull(result);
    }

  }
}
