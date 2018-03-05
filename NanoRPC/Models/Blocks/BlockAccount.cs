using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class BlockAccountRequest : IRPCAction
  {
    public string Action { get; } = "block_account";

    public string Hash { get; set; }
  }

  public class BlockAccountResponse
  {
    public string Account { get; set; }
  }
}
