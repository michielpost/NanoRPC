using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockCountTypeRequest : IRPCAction
  {
    public string Action { get; } = "block_count_type";

  }

  public class BlockCountTypeResponse
  {
    public long Send { get; set; }
    public long Receive { get; set; }
    public long Open { get; set; }
    public long Change { get; set; }

    public long Total => Send + Receive + Open + Change;

  }
}
