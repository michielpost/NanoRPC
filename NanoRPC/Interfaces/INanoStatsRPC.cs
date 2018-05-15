using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoStatsRPC
  {
    /// <summary>
    /// For configuration and other details, please see https://github.com/nanocurrency/raiblocks/wiki/Statistics
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<StatsResponse> Stats([Body]StatsRequest req);
  }
}
