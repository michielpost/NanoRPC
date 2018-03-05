using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class DelegatorsCountRequest : IRPCAction
  {
    public string Action { get; } = "delegators_count";

    public string Account { get; set; }
  }

  public class DelegatorsCountResponse
  {
    public string count { get; set; }
  }
}
