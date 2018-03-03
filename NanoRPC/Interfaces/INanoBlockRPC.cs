using Refit;
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
    Task<BlockResponse> GetBlock(BlockRequest req);

    /// <summary>
    /// Retrieves a json representations of blocks
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlocksResponse> GetBlocks(BlocksRequest req);

    /// <summary>
    /// Retrieves a json representations of blocks with transaction amount & block account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlocksInfoResponse> GetBlocksInfo(BlocksInfoRequest req);

    /// <summary>
    /// Returns the account containing block
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockAccountResponse> GetBlockAccount(BlockAccountRequest req);

    /// <summary>
    /// Reports the number of blocks in the ledger and unchecked synchronizing blocks
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockCountResponse> GetBlockCount(BlockCountRequest req);

    /// <summary>
    /// Reports the number of blocks in the ledger by type (send, receive, open, change)
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<BlockCountTypeResponse> GetBlockCountByType(BlockCountTypeRequest req);

    /// <summary>
    /// Returns a list of block hashes in the account chain starting at block up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ChainResponse> GetChain(ChainRequest req);

  }
}
