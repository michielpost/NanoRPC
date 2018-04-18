using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletLockRequest : IRPCAction
  {
    public string Action { get; } = "wallet_lock";

    public string Wallet { get; set; }

  }

  public class WalletLockResponse
  {
    public string Locked { get; set; }
  }
}
