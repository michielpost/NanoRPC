using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlocksRequest : IRPCAction
  {
    public string Action { get; } = "blocks";

    public List<string> Hashes { get; set; }
  }

  public class BlocksResponse
  {
    //TODO: Convert json to object
    public Dictionary<string, string> Blocks { get; set; }
  }
}
