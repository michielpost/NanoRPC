using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BootstrapAnyRequest : IRPCAction
  {
    public string Action { get; } = "bootstrap_any";
  }

  public class BootstrapAnyResponse : BootstrapResponse
  {
    public string Success { get; set; }
  }
}
