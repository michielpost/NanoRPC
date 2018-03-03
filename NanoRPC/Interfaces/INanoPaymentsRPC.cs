using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoPaymentsRPC
  {
    /// <summary>
    /// Begin a new payment session. Searches wallet for an account that's marked as available and has a 0 balance. If one is found, the account number is returned and is marked as unavailable. If no account is found, a new account is created, placed in the wallet, and returned.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PaymentBeginResponse> PaymentBegin(PaymentBeginRequest req);

   
  }
}
