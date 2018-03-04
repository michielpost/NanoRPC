using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkPeersClearRequest : IRPCAction
  {
    public string Action { get; } = "work_peers_clear";

  }

  public class WorkPeersClearResponse
  {
    public string Success { get; set; }
  }
}
