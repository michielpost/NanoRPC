using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ProcessRequest : IRPCAction
  {
    public string Action { get; } = "process";

    //TODO: Convert json to object
    public string Block { get; set; }
  }

  public class ProcessResponse
  {
    public string Hash { get; set; }
  }
}
