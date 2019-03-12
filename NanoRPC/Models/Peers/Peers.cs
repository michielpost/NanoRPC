using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PeersRequest : IRPCAction
  {
    public string Action { get; } = "peers";

    public bool? Peer_details { get; set; }

  }

  public class PeersResponse
  {
    public Dictionary<string, string> Peers { get; set; }
  }
}
