using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkCancelRequest : IRPCAction
  {
    public string Action { get; } = "work_cancel";

    public string Hash { get; set; }
  }
}
