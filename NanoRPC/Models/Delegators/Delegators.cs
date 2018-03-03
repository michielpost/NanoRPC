using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class DelegatorsRequest : IRPCAction
  {
    public string Action { get; } = "delegators";

    public string Account { get; set; }
  }

  public class DelegatorsResponse
  {
    public Dictionary<string, string> Delegators { get; set; }
  }
}
