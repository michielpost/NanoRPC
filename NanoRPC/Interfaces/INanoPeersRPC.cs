using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoPeersRPC
  {
    /// <summary>
    /// Returns a list of pairs of peer IPv6:port and its node network version
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PeersResponse> Peers(PeersRequest req);
   
  }
}
