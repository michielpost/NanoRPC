using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PendingRequest : IRPCAction
  {
    public string Action { get; } = "pending";

    public string Account { get; set; }

    public string Count { get; set; }

    /// <summary>
    /// Optional. Returns a list of pending block hashes with amount more or equal to threshold
    /// </summary>
    public string Threshold { get; set; }

    /// <summary>
    /// Optional. Returns a list of pending block hashes with amount and source accounts
    /// </summary>
    public bool? Source { get; set; }

    /// <summary>
    /// Boolean, false by default. Include active blocks without finished confirmations
    /// </summary>
    public bool? Include_active { get; set; }

    //TODO: Support different output for optional Source
  }

  public class PendingResponse
  {
    public List<string> Blocks { get; set; }
  }
}
