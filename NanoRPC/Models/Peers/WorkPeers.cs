using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkPeersRequest : IRPCAction
  {
    public string Action { get; } = "work_peers";
  }

  public class WorkPeersResponse
  {
    public List<string> Work_Peers { get; set; }
  }
}
