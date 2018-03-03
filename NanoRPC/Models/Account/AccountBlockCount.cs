using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountBlockCountRequest : IRPCAction
  {
    public string Action { get; } = "account_block_count";

    public string Account { get; set; }
  }

  public class AccountBlockCountResponse
  {
    public string Block_Count { get; set; }
  }
}
