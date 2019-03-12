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

    /// <summary>
    /// Clears all collected statistics. The "stat_duration_seconds" value in the "stats" action is also reset.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<StatsClearResponse> StatsClear([Body]StatsClearRequest req);
  }
}
