using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class VersionRequest : IRPCAction
  {
    public string Action { get; } = "version";
  }

  public class VersionResponse
  {
    /// <summary>
    /// RPC Version always retruns "1" as of 13/01/2018
    /// </summary>
    public string Rpc_Version { get; set; }
    public string Store_Version { get; set; }
    public string Node_Vendor { get; set; }
  }
}
