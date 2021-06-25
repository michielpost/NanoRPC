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

    public string Type { get; } = "state";
    public bool? Json_block { get; set; } = true;

    public string Account { get; set; }
    public string Representative { get; set; }
    public NanoAmount Balance { get; set; }
    public string Key { get; set; }
    public string Link { get; set; }
    public string? Previous { get; set; }


  }

  public class Block
  {
    public string Type { get; set; } = "state";
    public string Account { get; set; }
    public string? Previous { get; set; }
    public string Representative { get; set; }
    public NanoAmount Balance { get; set; }
    public string Key { get; set; }
    public string Link { get; set; }
    public string Link_as_account { get; set; }
    public string Signature { get; set; }
    public string Work { get; set; }
  }

  public class BlockCreateResponse
  {
    public string Hash { get; set; }
    public Block Block { get; set; }
  }
}
