using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class RepresentativesOnlineRequest : IRPCAction
  {
    public string Action { get; } = "representatives_online";

    /// <summary>
    /// Optional Returns a list of pairs of representative and its voting weight up to count
    /// </summary>
    public string Count { get; set; }

  }

  public class RepresentativesOnlineResponse
  {
    public Dictionary<string, string> Representatives { get; set; }
  }
}
