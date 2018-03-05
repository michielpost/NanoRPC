using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletContainsRequest : IRPCAction
  {
    public string Action { get; } = "wallet_contains";

    public string Wallet { get; set; }

    public string Account { get; set; }

  }

  public class WalletContainsResponse
  {
    public string Exists { get; set; }
  }
}
