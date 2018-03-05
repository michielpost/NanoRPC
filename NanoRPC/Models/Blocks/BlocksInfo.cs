using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlocksInfoRequest : IRPCAction
  {
    public string Action { get; } = "blocks_info";

    public List<string> Hashes { get; set; }

    /// <summary>
    /// Optional, Additionally checks if block is pending
    /// </summary>
    public bool? Pending { get; set; }

    /// <summary>
    /// Optional, returns source account for receive & open blocks (0 for send & change blocks)
    /// </summary>
    public bool? Source { get; set; }
  }

  public class BlocksInfoResponse
  {
    //TODO: Convert json to object
    public Dictionary<string, string> Blocks { get; set; }
  }
}
