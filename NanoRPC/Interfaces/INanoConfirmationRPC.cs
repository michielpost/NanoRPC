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

  }
}
