using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoSendRPC
  {
    /// <summary>
    /// Send amount from source in wallet to destination
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<SendResponse> Send(SendRequest req);
  }
}
