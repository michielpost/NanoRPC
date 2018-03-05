using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockRequest : IRPCAction
  {
    public string Action { get; } = "block";

    public string Hash { get; set; }
  }

  public class BlockResponse
  {
    //TODO: Convert json to object
    public string Contents { get; set; }
  }
}
