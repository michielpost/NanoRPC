using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoReceivingRPC
  {
    /// <summary>
    /// Receive pending block for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ReceiveResponse> Receive(ReceiveRequest req);
   
  }
}
