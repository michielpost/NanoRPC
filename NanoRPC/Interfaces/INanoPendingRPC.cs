using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoPendingRPC
  {
    /// <summary>
    /// Tells the node to look for pending blocks for any account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<SearchPendingResponse> SearchPending(SearchPendingRequest req);

    /// <summary>
    /// Tells the node to look for pending blocks for any account in all available wallets
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<SearchPendingAllResponse> SearchPendingAll(SearchPendingAllRequest req);

    /// <summary>
    /// Returns a list of block hashes which have not yet been received by this account.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PendingResponse> Pending(PendingRequest req);

    /// <summary>
    /// Check whether block is pending by hash
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PendingExistsResponse> PendingExists(PendingExistsRequest req);


  }
}
