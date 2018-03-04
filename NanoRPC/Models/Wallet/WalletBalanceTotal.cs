using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletBalanceTotalRequest : IRPCAction
  {
    public string Action { get; } = "wallet_balance_total";

    public string Wallet { get; set; }

  }

  public class WalletBalanceTotalResponse
  {
    public string Balance { get; set; }
    public string Pending { get; set; }
  }
}
