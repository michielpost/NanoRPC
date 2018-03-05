using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletRepublishRequest : IRPCAction
  {
    public string Action { get; } = "wallet_republish";

    public string Wallet { get; set; }

    public string Count { get; set; }

  }

  public class WalletRepublishResponse
  {
    public List<string> Blocks { get; set; }
  }
}
