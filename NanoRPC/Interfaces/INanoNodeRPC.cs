using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoNodeRPC
  {
    /// <summary>
    /// Method to safely shutdown node
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<StopResponse> Stop([Body]StopRequest req);

    /// <summary>
    /// Returns version information for RPC, Store & Node (Major & Minor version)
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<VersionResponse> Version([Body]VersionRequest req);

    /// <summary>
    /// enable_control required, version 17.0+
    /// This is an internal/diagnostic RPC, do not rely on its interface being stable
    /// Derive prive, public keys and account number from node ID
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<NodeIdResponse> NodeId([Body]NodeIdRequest req);

    /// <summary>
    /// enable_control required, version 17.0+
    /// This is an internal/diagnostic RPC, do not rely on its interface being stable
    /// Removing node ID(restart required to take effect)
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<NodeIdDeleteResponse> NodeIdDelete([Body]NodeIdDeleteRequest req);

    /// <summary>
    /// Return node uptime in seconds
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<UptimeResponse> Uptime([Body]UptimeRequest req);

  }
}
