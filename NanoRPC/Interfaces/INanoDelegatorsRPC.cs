using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoDelegatorsRPC
  {
    /// <summary>
    /// Returns a list of pairs of delegator names given account a representative and its balance
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<DelegatorsResponse> GetDelegators(DelegatorsRequest req);

    /// <summary>
    /// Get number of delegators for a specific representative account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<DelegatorsCountResponse> GetDelegatorsCount(DelegatorsCountRequest req);
  }
}
