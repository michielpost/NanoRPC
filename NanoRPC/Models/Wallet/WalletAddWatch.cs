using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletAddWatchRequest : IRPCAction
  {
    public string Action { get; } = "wallet_add_watch";

    public string Wallet { get; set; }

    public List<string> Accounts { get; set; }

  }

  public class WalletAddWatchResponse
  {
    public string Success { get; set; }
  }
}
