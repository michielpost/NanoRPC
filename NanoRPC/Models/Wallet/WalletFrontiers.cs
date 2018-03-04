using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletFrontiersRequest : IRPCAction
  {
    public string Action { get; } = "wallet_frontiers";

    public string Wallet { get; set; }

  }

  public class WalletFrontiersResponse
  {
    public Dictionary<string, string> Frontiers { get; set; }
  }
}
