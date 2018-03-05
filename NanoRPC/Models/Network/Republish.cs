using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class RepublishRequest : IRPCAction
  {
    public string Action { get; } = "republish";

    public string Hash { get; set; }

    /// <summary>
    /// Optional. Additionally rebroadcast source chain blocks for receive/open up to sources depth
    /// </summary>
    public string Count { get; set; }

    /// <summary>
    /// Optional. Additionally rebroadcast source chain blocks for receive/open up to sources depth
    /// </summary>
    public string Sources { get; set; }

    /// <summary>
    /// Optional. Additionally rebroadcast destination chain blocks from receive up to destinations depth
    /// </summary>
    public string Destinations { get; set; }
  }

  public class RepublishResponse
  {
    public List<string> Blocks { get; set; }
  }
}
