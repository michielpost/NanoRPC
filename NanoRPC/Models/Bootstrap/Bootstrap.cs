using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BootstrapRequest : IRPCAction
  {
    public string Action { get; } = "bootstrap";

    public string Address { get; set; }
    public string Port { get; set; }
  }

  public class BootstrapResponse
  {
    public string Success { get; set; }
  }
}
