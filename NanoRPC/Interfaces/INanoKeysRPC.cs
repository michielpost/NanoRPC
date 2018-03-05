using RestEase;
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
    Task<DeterministicKeyResponse> DeterministicKey([Body]DeterministicKeyRequest req);

    /// <summary>
    /// Generates an adhoc random keypair
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<KeyCreateResponse> KeyCreate([Body]KeyCreateRequest req);

    /// <summary>
    /// Derive public key and account number from private key
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<KeyExpandResponse> KeyExpand([Body]KeyExpandRequest req);
  }
}
