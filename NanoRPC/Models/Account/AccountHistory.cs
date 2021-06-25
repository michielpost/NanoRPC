using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountHistoryRequest : IRPCAction
  {
    public string Action { get; } = "account_history";

    public string Account { get; set; }

    public string Count { get; set; }

    public bool Raw { get; set; }

    public string Head { get; set; }

    public string Offset { get; set; }
  }

  public class AccountHistoryResponse
  {
    public List<AccountHistoryDetail> History { get; set; } = new List<AccountHistoryDetail>();

  }

  [DebuggerDisplay("{LocalTimeStamp} - {Type} - {Amount.ToString(AmountBase.Nano)}")]
  public class AccountHistoryDetail
  {
    public string Hash { get; set; }
    public string Type { get; set; }
    public string Account { get; set; }
    public NanoAmount Amount { get; set; }

    [DebuggerDisplay("{LocalTimeStamp}")]
    public string local_timestamp { get; set; }

    public string Height { get; set; }

    public DateTime? LocalTimeStamp
    {
      get
      {
        long ticks;

        if (long.TryParse(local_timestamp, out ticks))
          return DateTimeOffset.FromUnixTimeSeconds(ticks).DateTime;

        return null;
      }
    }
  }
}
