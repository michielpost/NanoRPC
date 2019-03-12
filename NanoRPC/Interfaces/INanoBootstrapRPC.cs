using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoBootstrapRPC
  {
    /// <summary>
    /// Initialize bootstrap to specific IP address and port
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BootstrapResponse> Bootstrap([Body]BootstrapRequest req);

    /// <summary>
    ///Initialize multi-connection bootstrap to random peers
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BootstrapResponse> BootstrapAny([Body]BootstrapAnyRequest req);

    /// <summary>
    /// Initialize lazy bootstrap with given block hash
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BootstrapLazyResponse> BootstrapLazy([Body]BootstrapLazyRequest req);

    /// <summary>
    /// This is an internal/diagnostic RPC, do not rely on its interface being stable
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BootstrapStatusResponse> BootstrapStatus([Body]BootstrapStatusRequest req);
  }
}
