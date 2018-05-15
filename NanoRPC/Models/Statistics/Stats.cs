using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  /// <summary>
  /// https://github.com/nanocurrency/raiblocks/wiki/Statistics
  /// </summary>
  public class StatsRequest : IRPCAction
  {
    public string Action { get; } = "stats";

    /// <summary>
    /// Value can be counters of sample
    /// </summary>
    public string Type { get; set; } = "counters";

  }

  public class StatsResponse
  {
    public string Type { get; set; }
    public string Created { get; set; }
    public List<StatsEntry> Entries { get; set; }

  }

  public class StatsEntry
  {
    public string Time { get; set; }
    public string Type { get; set; }
    public string Detail { get; set; }
    public string Dir { get; set; }
    public string Value { get; set; }
  }

}
