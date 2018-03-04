using Refit;
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
    Task<StopResponse> Stop(StopRequest req);

    /// <summary>
    /// Returns version information for RPC, Store & Node (Major & Minor version)
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<VersionResponse> Version(VersionRequest req);

  }
}
