using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountBalanceRequest : IRPCAction
  {
    public string Action { get; } = "account_balance";

    public string Account { get; set; }
  }

  public class AccountBalanceResponse
  {
    public string Balance { get; set; }
    public string Pending { get; set; }
  }
}
