using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoNetworkRPC
  {
    /// <summary>
    /// Returns how many rai are in the public supply
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AvailableSupplyResponse> GetAvailableSupply(AvailableSupplyRequest req);

    [Post("")]
    Task KeepAlive(KeepAliveRequest req);


  }
}
