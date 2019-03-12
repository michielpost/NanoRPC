using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockInfoRequest : IRPCAction
  {
    public string Action { get; } = "block_info";

    public string Hash { get; set; }

    public bool? Json_block { get; set; }

  }

  public class BlockInfoResponse
  {
    public string Block_account { get; set; }
    public string Amount { get; set; }
    public string Balance { get; set; }
    public string Height { get; set; }
    public string Local_timestamp { get; set; }
    public string Confirmed { get; set; }
    public string Contents { get; set; }
    public string Subtype { get; set; }
  }
}
