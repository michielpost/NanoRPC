using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoFrontiersRPC
  {
    /// <summary>
    /// Returns a list of pairs of account and block hash representing the head block starting at account up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<FrontiersResponse> Frontiers(FrontiersRequest req);
  }
}
