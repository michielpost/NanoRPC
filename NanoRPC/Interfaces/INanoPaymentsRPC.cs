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

    /// <summary>
    /// Marks all accounts in wallet as available for being used as a payment session.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PaymentInitResponse> PaymentInit(PaymentInitRequest req);

    /// <summary>
    /// End a payment session. Marks the account as available for use in a payment session. 
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task PaymentEnd(PaymentEndRequest req);

    /// <summary>
    /// Wait for payment of 'amount' to arrive in 'account' or until 'timeout' milliseconds have elapsed.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PaymentWaitResponse> PaymentWait(PaymentWaitRequest req);

  }
}
