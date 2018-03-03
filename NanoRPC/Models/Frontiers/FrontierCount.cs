using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class FrontierCountRequest : IRPCAction
  {
    public string Action { get; } = "frontier_count";
  }

  public class FrontierCountResponse
  {
    public string Count { get; set; }
  }
}
