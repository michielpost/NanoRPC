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

    /// <summary>
    /// Returns receive minimum for node
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ReceiveMinimumResponse> ReceiveMinimum(ReceiveMinimumRequest req);

    /// <summary>
    /// Set amount as new receive minimum for node until restart
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ReceiveMinimumSetResponse> ReceiveMinimumSet(ReceiveMinimumSetRequest req);

  }
}
