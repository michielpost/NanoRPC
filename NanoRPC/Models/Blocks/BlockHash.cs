using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockHashRequest : IRPCAction
  {
    public string Action { get; } = "block_hash";

    public string Block { get; set; }

    public bool? Json_block { get; set; }

  }

  public class BlockHashResponse
  {
    public string Hash { get; set; }
  }
}
