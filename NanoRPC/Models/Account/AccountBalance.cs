using NanoRPC.Models;
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
    public NanoAmount Balance { get; set; }
    public NanoAmount Pending { get; set; }
    public NanoAmount Receivable { get; set; }
  }
}
