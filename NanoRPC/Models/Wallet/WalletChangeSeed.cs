using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletChangeSeedRequest : IRPCAction
  {
    public string Action { get; } = "wallet_change_seed";

    public string Wallet { get; set; }

    public string Seed { get; set; }

  
  }

  public class WalletChangeSeedResponse
  {
    public string Success { get; set; }
  }
}
