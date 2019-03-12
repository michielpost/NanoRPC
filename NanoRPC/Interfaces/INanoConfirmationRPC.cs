using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoConfirmationsRPC
  {

    /// <summary>
    /// Request confirmation for block from known online representative nodes. Check results with Confirmation history
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockConfirmResponse> BlockConfirm([Body]BlockConfirmRequest req);

    /// <summary>
    /// Returns hash & tally weight for recent elections winners
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConfirmationHistoryResponse> ConfirmationHistory([Body]ConfirmationHistoryRequest req);

    /// <summary>
    /// Returns info about active election by root. Including announcements count, last winner (initially local ledger block), total tally of voted representatives, concurrent blocks with tally & block contents for each
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConfirmationInfoResponse> ConfirmationInfo([Body]ConfirmationInfoRequest req);

    /// <summary>
    /// Returns information about node elections settings & observed network state: delta tally required to rollback block, percentage of online weight for delta, minimum online weight to confirm block, currently observed online total weight, known peers total weight
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConfirmationQuorumResponse> ConfirmationQuorum([Body]ConfirmationQuorumRequest req);

    /// <summary>
    /// Returns list of active elections roots (excluting stopped & aborted elections). Find info about specific root with confirmation_info
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConfirmationActiveResponse> ConfirmationActive([Body]ConfirmationActiveRequest req);

  }
}
