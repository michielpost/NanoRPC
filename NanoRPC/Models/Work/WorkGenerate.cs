using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkGenerateRequest : IRPCAction
  {
    public string Action { get; } = "work_generate";

    public string Hash { get; set; }
  }

  public class WorkGenerateResponse
  {
    public string Work { get; set; }
  }
}
