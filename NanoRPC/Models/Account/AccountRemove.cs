using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountRemoveRequest : IRPCAction
  {
    public string Action { get; } = "account_remove";

    public string Wallet { get; set; }
    public string Account { get; set; }
  }

  public class AccountRemoveResponse
  {
    public string Removed { get; set; }

  }
}
