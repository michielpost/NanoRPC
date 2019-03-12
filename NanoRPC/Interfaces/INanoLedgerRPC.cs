using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoLedgerRPC
  {
    /// <summary>
    /// Returns frontier, open block, change representative block, balance, last modified timestamp from local database & block count starting at account up to count
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<LedgerResponse> Ledger([Body]LedgerRequest req);

    /// <summary>
    /// Returns a list of block hashes in the account chain ending at block up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<SuccessorsResponse> Successors([Body]SuccessorsRequest req);

    /// <summary>
    /// Returns the total pending balance for unopened accounts in the local database, starting at account (optional) up to count (optional), sorted by account number. Notes: By default excludes the burn account.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<UnopenedResponse> Unopened([Body]UnopenedRequest req);
  }
}
