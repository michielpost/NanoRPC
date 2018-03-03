using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class FrontiersRequest : IRPCAction
  {
    public string Action { get; } = "frontiers";

    public string Account { get; set; }
    public string Count { get; set; }
  }

  public class FrontiersResponse
  {
    public Dictionary<string, string> Frontiers { get; set; }
  }
}
