using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountsBalancesRequest : IRPCAction
  {
    public string Action { get; } = "accounts_balances";

    public List<string> Accounts { get; set; }
  }

  public class AccountsBalancesResponse
  {
    public Dictionary<string, AccountBalance> Balances { get; set; }

  }

  public class AccountBalance
  {
    public string Balance { get; set; }
    public string Pending { get; set; }

  }
}
