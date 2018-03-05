using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoUncheckedBlocksRPC
  {

    /// <summary>
    /// Returns a list of pairs of unchecked synchronizing block hash and its json representation up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<UncheckedResponse> Unchecked([Body]UncheckedRequest req);

    /// <summary>
    /// Clear unchecked synchronizing blocks
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<UncheckedClearResponse> UncheckedClear([Body]UncheckedClearRequest req);

    /// <summary>
    /// Retrieves a json representation of unchecked synchronizing block by hash
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<UncheckedGetResponse> UncheckedGet([Body]UncheckedGetRequest req);

    /// <summary>
    /// Retrieves unchecked database keys, blocks hashes & a json representations of unchecked pending blocks starting from key up to count
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<UncheckedKeysResponse> UncheckedKeys([Body]UncheckedKeysRequest req);
  }
}
