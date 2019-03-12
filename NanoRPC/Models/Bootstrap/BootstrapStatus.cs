using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BootstrapStatusRequest : IRPCAction
  {
    public string Action { get; } = "bootstrap_status";

    public string Hash { get; set; }

    /// <summary>
    /// Optional Boolean, false by default. Manually force closing of all current bootstraps
    /// </summary>
    public bool? Force { get; set; }
  }

  public class BootstrapStatusResponse
  {
    public string Clients { get; set; }
    public string Pulls { get; set; }
    public string Pulling { get; set; }
    public string Connections { get; set; }
    public string Idle { get; set; }
    public string Target_connections { get; set; }
    public string Total_blocks { get; set; }
    public string Lazy_mode { get; set; }
    public string Lazy_blocks { get; set; }
    public string Lazy_state_unknown { get; set; }
    public string Lazy_balances { get; set; }
    public string Lazy_pulls { get; set; }
    public string Lazy_stopped { get; set; }
    public string Lazy_keys { get; set; }
    public string Lazy_key_1 { get; set; }
  }
}
