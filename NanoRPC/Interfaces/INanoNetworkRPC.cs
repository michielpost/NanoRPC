using RestEase;
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
    Task<AvailableSupplyResponse> AvailableSupply([Body]AvailableSupplyRequest req);

    /// <summary>
    /// Tells the node to send a keepalive packet to address:port
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task KeepAlive([Body]KeepAliveRequest req);

    /// <summary>
    /// Rebroadcast blocks starting at hash to the network
    /// </summary>
    [Post("")]
    Task<RepublishResponse> Republish([Body]RepublishRequest req);

  }
}
