using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountsPendingRequest : IRPCAction
  {
    public string Action { get; } = "accounts_pending";

    public List<string> Accounts { get; set; }

    public int Count { get; set; }

    //TODO: Support optional Threshold and Source, but response will be different
  }

  public class AccountsPendingResponse
  {
    public Dictionary<string, List<string>> Blocks { get; set; }

  }
}
