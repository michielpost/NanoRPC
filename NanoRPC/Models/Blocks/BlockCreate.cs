using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockCreateRequest : IRPCAction
  {
    public string Action { get; } = "block_create";

    public string Type { get; set; }
    public string Balance { get; set; }
    public string Key { get; set; }
    public string Representative { get; set; }
    public string Link { get; set; }
    public string Previous { get; set; }

    public bool? Json_block { get; set; }

  }

  public class BlockCreateResponse
  {
    public string Hash { get; set; }
    public string Block { get; set; }
  }
}
