using RestEase;
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
    Task WorkCancel([Body]WorkCancelRequest req);

    /// <summary>
    /// Generates work for block
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkGenerateResponse> WorkGenerate([Body]WorkGenerateRequest req);

    /// <summary>
    /// Retrieves work for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkGetResponse> WorkGet([Body]WorkGetRequest req);

    /// <summary>
    /// Set work for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WorkSetResponse> WorkSet([Body]WorkSetRequest req);
  }
}
