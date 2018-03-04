using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoWorkRPC
  {

    /// <summary>
    /// Stop generating work for block
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task WorkCancel(WorkCancelRequest req);

    /// <summary>
    /// Generates work for block
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkGenerateResponse> WorkGenerate(WorkGenerateRequest req);

    /// <summary>
    /// Retrieves work for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkGetResponse> WorkGet(WorkGetRequest req);

    /// <summary>
    /// Set work for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkSetResponse> WorkSet(WorkSetRequest req);
  }
}
