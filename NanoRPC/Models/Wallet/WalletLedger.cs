using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletLedgerRequest : IRPCAction
  {
    public string Action { get; } = "wallet_ledger";

    public string Wallet { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public bool? Representative { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public bool? Weight { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public bool? Pending { get; set; }

    /// <summary>
    /// Optional: Return only accounts modified in local database after specific timestamp
    /// </summary>
    public string Modified_since { get; set; }
  }

  public class WalletLedgerResponse
  {
    public Dictionary<string, Account> Accounts { get; set; }
  }
}
