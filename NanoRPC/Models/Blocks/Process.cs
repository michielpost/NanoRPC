using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ProcessRequest : IRPCAction
  {
    public string Action { get; } = "process";
    public bool Json_block { get; } = true;

    public string SubType { get; set; }

    public Block Block { get; set; }


  }

  public class ProcessResponse
  {
    public string Hash { get; set; }
  }
}
