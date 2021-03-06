using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class StopRequest : IRPCAction
  {
    public string Action { get; } = "stop";
  }

  public class StopResponse
  {
    public string Success { get; set; }
  }
}
