using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletDestroyRequest : IRPCAction
  {
    public string Action { get; } = "wallet_destroy";

    public string Wallet { get; set; }

  }
  
}
