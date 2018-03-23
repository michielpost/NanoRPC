using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletBalancesRequest : IRPCAction
  {
    public string Action { get; } = "wallet_balances";

    public string Wallet { get; set; }

    /// <summary>
    /// Optional. Returns wallet accounts balances more or equal to threshold
    /// </summary>
    public string Threshold { get; set; }

  }

  public class WalletBalancesResponse
  {
    public Dictionary<string, WalletBalance> Balances { get; set; }
  }

  [DebuggerDisplay("Balance = {Balance}, Pending = {Pending}")]
  public class WalletBalance
  {
    public NanoAmount Balance { get; set; }
    public NanoAmount Pending { get; set; }
  }
}
