using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkSetRequest : IRPCAction
  {
    public string Action { get; } = "work_set";

    public string Wallet { get; set; }

    public string Account { get; set; }
    public string Work { get; set; }
  }

  public class WorkSetResponse
  {
    public string Success { get; set; }
  }
}
