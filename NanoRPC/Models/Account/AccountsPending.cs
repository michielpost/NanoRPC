using NanoRPC.Models;
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

    public int Count { get; set; } = 1;

    public bool Sorting { get; } = true;
    public bool? Include_Active { get; set; }
    public bool? include_only_confirmed { get; set; } = true;

    //TODO: Support optional Threshold and Source, but response will be different
  }

  public class AccountsPendingResponse
  {
    public Dictionary<string, Dictionary<string, NanoAmount>> Blocks { get; set; } = new();

  }
}
