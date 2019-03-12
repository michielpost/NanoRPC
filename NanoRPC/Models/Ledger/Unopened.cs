using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class UnopenedRequest : IRPCAction
  {
    public string Action { get; } = "unopened";

    public string Account { get; set; }
    public string Count { get; set; }

  }

  public class UnopenedResponse
  {
    public Dictionary<string, Account> Accounts { get; set; }
  }

}
