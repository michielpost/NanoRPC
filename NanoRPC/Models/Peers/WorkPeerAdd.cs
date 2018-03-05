using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkPeerAddRequest : IRPCAction
  {
    public string Action { get; } = "work_peer_add";

    public string Address { get; set; }
    public string Port { get; set; }
  }

  public class WorkPeerAddResponse
  {
    public string Success { get; set; }
  }
}
