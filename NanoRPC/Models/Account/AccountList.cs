using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountListRequest : IRPCAction
  {
    public string Action { get; } = "account_list";

    public string Wallet { get; set; }
  }

  public class AccountListResponse
  {
    public List<string> Accounts { get; set; }

  }
}
