using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class NodeIdRequest : IRPCAction
  {
    public string Action { get; } = "node_id";
  }

  public class NodeIdResponse
  {
    public string Private { get; set; }
    public string Public { get; set; }
    public string As_Account { get; set; }
  }
}
