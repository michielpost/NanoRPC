using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class KeepAliveRequest : IRPCAction
  {
    public string Action { get; } = "keepalive";

    public string Addres { get; set; }
    public string Port { get; set; }
  }
}
