using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountMoveRequest : IRPCAction
  {
    public string Action { get; } = "account_move";

    public string Wallet { get; set; }
    public string Source { get; set; }
    public List<string> Accounts { get; set; }

  }

  public class AccountMoveResponse
  {
    public string Moved { get; set; }

  }
}
