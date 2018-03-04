using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PeersRequest : IRPCAction
  {
    public string Action { get; } = "peers";
  }

  public class PeersResponse
  {
    public Dictionary<string, string> Peers { get; set; }
  }
}
