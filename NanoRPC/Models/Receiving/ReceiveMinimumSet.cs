using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ReceiveMinimumSetRequest : IRPCAction
  {
    public string Action { get; } = "receive_minimum_set";

    public string Amount { get; set; }
  }

  public class ReceiveMinimumSetResponse
  {
    public string Success { get; set; }
  }
}
