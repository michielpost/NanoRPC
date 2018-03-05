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

    public string Hash { get; set; }
  }

  public class BootstrapAnyResponse : BootstrapResponse
  {
    //TODO: Convert json to object
    public string Contents { get; set; }
  }
}
