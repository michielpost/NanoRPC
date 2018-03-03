using NanoRPC.Models;
using Refit;
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
    public string Send { get; set; }
    public string Receive { get; set; }
    public string Open { get; set; }
    public string Change { get; set; }
  }
}
