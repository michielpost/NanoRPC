using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class SuccessorsRequest : IRPCAction
  {
    public string Action { get; } = "successors";

    public string Block { get; set; }
    public string Count { get; set; }
  }

  public class SuccessorsResponse
  {
    public List<string> Blocks { get; set; }
  }

  
}
