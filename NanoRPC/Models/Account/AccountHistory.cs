using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountHistoryRequest : IRPCAction
  {
    public string Action { get; } = "account_history";

    public string Key { get; set; }

    public string Count { get; set; }
  }

  public class AccountHistoryResponse
  {
    public List<AccountHistoryDetail> History { get; set; }

  }

  public class AccountHistoryDetail
  {
    public string Hash { get; set; }
    public string Type { get; set; }
    public string Account { get; set; }
    public string Amount { get; set; }
  }
}
