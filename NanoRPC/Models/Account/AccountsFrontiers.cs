using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountsFrontiersRequest : IRPCAction
  {
    public string Action { get; } = "accounts_frontiers";

    public List<string> Accounts { get; set; }
  }

  public class AccountsFrontiersResponse
  {
    public Dictionary<string, string> Frontiers { get; set; }

  }
}
