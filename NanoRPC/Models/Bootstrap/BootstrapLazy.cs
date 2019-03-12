using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BootstrapLazyRequest : IRPCAction
  {
    public string Action { get; } = "bootstrap_lazy";

    public string Hash { get; set; }

    /// <summary>
    /// Optional Boolean, false by default. Manually force closing of all current bootstraps
    /// </summary>
    public bool? Force { get; set; }
  }

  public class BootstrapLazyResponse
  {
    public string Started { get; set; }
  }
}
