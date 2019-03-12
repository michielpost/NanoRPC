using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class UptimeRequest : IRPCAction
  {
    public string Action { get; } = "uptime";
  }

  public class UptimeResponse
  {
    public string Seconds { get; set; }
  }
}
