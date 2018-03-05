using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ReceiveMinimumRequest : IRPCAction
  {
    public string Action { get; } = "receive_minimum";
  }

  public class ReceiveMinimumResponse
  {
    public string Amount { get; set; }
  }
}
