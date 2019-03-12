using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class NodeIdDeleteRequest : IRPCAction
  {
    public string Action { get; } = "node_id_delete";
  }

  public class NodeIdDeleteResponse
  {
    public string Deleted { get; set; }
  }
}
