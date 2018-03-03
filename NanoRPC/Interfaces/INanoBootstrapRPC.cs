using Refit;
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
    Task<BootstrapResponse> Bootstrap(BootstrapRequest req);

    /// <summary>
    ///Initialize multi-connection bootstrap to random peers
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BootstrapResponse> BootstrapAny(BootstrapAnyRequest req);
  }
}
