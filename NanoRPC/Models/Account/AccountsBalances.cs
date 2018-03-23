using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

  [DebuggerDisplay("Balance = {Balance}, Pending = {Pending}")]
  public class AccountBalance
  {
    public NanoAmount Balance { get; set; }
    public NanoAmount Pending { get; set; }

  }
}
