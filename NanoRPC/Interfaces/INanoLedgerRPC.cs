using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoLedgerRPC
  {
    /// <summary>
    /// Reports send/receive information for a chain of blocks
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<HistoryResponse> History(HistoryRequest req);

    /// <summary>
    /// Returns frontier, open block, change representative block, balance, last modified timestamp from local database & block count starting at account up to count
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<LedgerResponse> Ledger(LedgerRequest req);
  }
}
