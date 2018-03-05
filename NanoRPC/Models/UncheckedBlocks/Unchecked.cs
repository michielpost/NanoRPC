using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class UncheckedRequest : IRPCAction
  {
    public string Action { get; } = "unchecked";

    public string Count { get; set; }
  }

  public class UncheckedResponse
  {
    public Dictionary<string, string> Blocks { get; set; }
  }
}
