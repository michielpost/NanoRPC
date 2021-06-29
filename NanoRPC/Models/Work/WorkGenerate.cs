using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkGenerateRequest : IRPCAction
  {
    public string Action { get; } = "work_generate";

    public string Hash { get; set; }

    /// <summary>
    /// If the optional use_peers parameter is set to true, then the node will query its work peers (if it has any). Without this parameter, the node will only generate work locally.
    /// </summary>
    public string Use_peers { get; set; }

    /// <summary>
    /// Optional Difficulty value (16 hexadecimal digits string, 64 bit). Uses difficulty value to generate work
    /// </summary>
    public string Difficulty { get; set; }

  }

  public class WorkGenerateResponse : BaseResponse
  {
    public string? Work { get; set; }
  }
}
