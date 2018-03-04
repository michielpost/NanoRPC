using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletLockedRequest : IRPCAction
  {
    public string Action { get; } = "wallet_locked";

    public string Wallet { get; set; }

  }

  public class WalletLockedResponse
  {
    public string Locked { get; set; }
  }
}
