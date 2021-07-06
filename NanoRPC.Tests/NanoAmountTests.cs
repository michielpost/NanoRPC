using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class NanoAmountTests
  {
    [TestMethod]
    public void TestRawAmount()
    {

      NanoAmount raw = new NanoAmount(1, AmountBase.raw);
      BigInteger rawResult = 1;
      Assert.AreEqual(rawResult, raw.Raw);


      NanoAmount nano = new NanoAmount(1, AmountBase.Nano);
      BigInteger nanoResult = BigInteger.Parse("1000000000000000000000000000000");
      Assert.AreEqual(nanoResult, nano.Raw);

      var asString = nano.ToString(AmountBase.xrb);
      var asNano = nano.ConvertToDecimal(AmountBase.Nano);

      NanoAmount rai = new NanoAmount(1, AmountBase.rai);
      BigInteger raiResult = BigInteger.Parse("1000000000000000000000000");
      Assert.AreEqual(raiResult, rai.Raw);

      var raiAsString = rai.ToString(AmountBase.Nano);
      var raiAsNano = rai.ConvertToDecimal(AmountBase.Nano);

      decimal dRai = 0.000001m;
      Assert.AreEqual(dRai, raiAsNano);

    }
  }
}
