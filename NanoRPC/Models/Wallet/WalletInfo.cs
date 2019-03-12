using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletInfoRequest : IRPCAction
  {
    public string Action { get; } = "wallet_info";

    public string Wallet { get; set; }

  }

  public class WalletInfoResponse
  {
    public NanoAmount Balance { get; set; }
    public NanoAmount Pending { get; set; }

    public string Accounts_Count { get; set; }
    public string Adhoc_Count { get; set; }
    public string Deterministic_Count { get; set; }
    public string Deterministic_Index { get; set; }
  }
}
