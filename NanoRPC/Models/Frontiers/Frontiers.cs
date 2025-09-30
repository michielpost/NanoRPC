using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class FrontiersRequest : IRPCAction
  {
    public string Action { get; } = "frontiers";

    /// <summary>
    /// Uses nano_1111111111111111111111111111111111111111111111111111hifc8npp as default value
    /// </summary>
    public string Account { get; set; } = "nano_1111111111111111111111111111111111111111111111111111hifc8npp"; //Default value

    /// <summary>
    /// Use -1 for all
    /// </summary>
    public long Count { get; set; }
  }

  public class FrontiersResponse
  {
    /// <summary>
    /// Address / PublicKey
    /// </summary>
    public Dictionary<string, string> Frontiers { get; set; }
  }
}
