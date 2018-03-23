using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoFrontiersRPC
  {
    /// <summary>
    /// Reports the number of accounts in the ledger
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<FrontierCountResponse> FrontierCount([Body]FrontierCountRequest req);

    /// <summary>
    /// Returns a (alphabetically sorted) list of pairs of account and block hash representing the head block starting at account up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<FrontiersResponse> Frontiers([Body]FrontiersRequest req);
  }
}
