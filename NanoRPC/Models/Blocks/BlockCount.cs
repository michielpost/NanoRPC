using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockCountRequest : IRPCAction
  {
    public string Action { get; } = "block_count";

  }

  public class BlockCountResponse
  {
    public long Count { get; set; }
    public long Unchecked { get; set; }

    public long Total => Count + Unchecked;
  }
}
