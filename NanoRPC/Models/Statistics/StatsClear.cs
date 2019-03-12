using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class StatsClearRequest : IRPCAction
  {
    public string Action { get; } = "stats_clear";
  }

  public class StatsClearResponse
  {
    public string Success { get; set; }
  }
}
