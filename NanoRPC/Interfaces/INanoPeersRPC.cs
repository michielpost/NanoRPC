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

    /// <summary>
    /// Add specific IP address and port as work peer for node until restart
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkPeerAddResponse> WorkPeerAdd(WorkPeerAddRequest req);

    /// <summary>
    /// Retrieve work peers
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkPeersResponse> WorkPeers(WorkPeersRequest req);

    /// <summary>
    /// Clear work peers node list until restart
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkPeersClearResponse> WorkPeersClear(WorkPeersClearRequest req);

    /// <summary>
    /// Check whether work is valid for block
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkValidateResponse> WorkValidate(WorkValidateRequest req);

  }
}
