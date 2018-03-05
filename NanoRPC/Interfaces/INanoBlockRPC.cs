using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoBlockRPC
  {
    /// <summary>
    /// Retrieves a json representation of block
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockResponse> Block([Body]BlockRequest req);

    /// <summary>
    /// Retrieves a json representations of blocks
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlocksResponse> Blocks([Body]BlocksRequest req);

    /// <summary>
    /// Retrieves a json representations of blocks with transaction amount & block account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlocksInfoResponse> BlocksInfo([Body]BlocksInfoRequest req);

    /// <summary>
    /// Returns the account containing block
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockAccountResponse> BlockAccount([Body]BlockAccountRequest req);

    /// <summary>
    /// Reports the number of blocks in the ledger and unchecked synchronizing blocks
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockCountResponse> BlockCount([Body]BlockCountRequest req);

    /// <summary>
    /// Reports the number of blocks in the ledger by type (send, receive, open, change)
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockCountTypeResponse> BlockCountType([Body]BlockCountTypeRequest req);

    /// <summary>
    /// Returns a list of block hashes in the account chain starting at block up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ChainResponse> Chain([Body]ChainRequest req);

    /// <summary>
    /// Publish block to the network
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ProcessResponse> Process([Body]ProcessRequest req);

  }
}
