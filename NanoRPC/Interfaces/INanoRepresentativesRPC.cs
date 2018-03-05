using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoRepresentativesRPC
  {
    /// <summary>
    /// Returns a list of pairs of representative and its voting weight
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<RepresentativesResponse> Representatives([Body]RepresentativesRequest req);

    /// <summary>
    /// Returns the default representative for wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletRepresentativeResponse> WalletRepresentative([Body]WalletRepresentativeRequest req);

    /// <summary>
    /// Sets the default representative for wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletRepresentativeSetResponse> WalletRepresentativeSet([Body]WalletRepresentativeSetRequest req);

  }
}
