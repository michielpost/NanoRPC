using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class BlockConfirmRequest : IRPCAction
  {
    public string Action { get; } = "block_confirm";

    public string Hash { get; set; }
  }

  public class BlockConfirmResponse
  {
    public string Started { get; set; }
  }
}
