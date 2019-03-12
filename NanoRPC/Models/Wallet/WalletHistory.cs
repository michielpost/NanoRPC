using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletHistoryRequest : IRPCAction
  {
    public string Action { get; } = "wallet_history";

    public string Wallet { get; set; }

    /// <summary>
    /// Optional UNIX timestamp (number), 0 by default. Return only accounts modified in local database after specific timestamp
    /// </summary>
    public string Modified_since { get; set; }

  }

  public class WalletHistoryResponse
  {
    public List<History> History { get; set; }
  }

  public class History
  {
    public string Type { get; set; }
    public string Account { get; set; }
    public NanoAmount Amount { get; set; }
    public string Block_account { get; set; }
    public string Hash { get; set; }
    public string Local_timestamp { get; set; }
  }
}
