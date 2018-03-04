using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class RepresentativesRequest : IRPCAction
  {
    public string Action { get; } = "representatives";

    /// <summary>
    /// Optional Returns a list of pairs of representative and its voting weight up to count
    /// </summary>
    public string Count { get; set; }

    /// <summary>
    /// Optional. Additional sorting represetntatives in descending order
    /// </summary>
    public bool? Sorting { get; set; }

  }

  public class RepresentativesResponse
  {
    public Dictionary<string, string> Representatives { get; set; }
  }
}
