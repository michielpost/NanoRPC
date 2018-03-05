using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PendingExistsRequest : IRPCAction
  {
    public string Action { get; } = "pending_exists";

    public string Hash { get; set; }

  }

  public class PendingExistsResponse
  {
    public string Exists { get; set; }
  }
}
