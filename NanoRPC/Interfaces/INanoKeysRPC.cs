using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoKeysRPC
  {
    /// <summary>
    /// Derive deterministic keypair from seed based on index
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<DeterministicKeyResponse> DeterministicKey(DeterministicKeyRequest req);

    /// <summary>
    /// Generates an adhoc random keypair
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<KeyCreateResponse> KeyCreate(KeyCreateRequest req);

    /// <summary>
    /// Derive public key and account number from private key
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<KeyExpandResponse> KeyExpand(KeyExpandRequest req);
  }
}
