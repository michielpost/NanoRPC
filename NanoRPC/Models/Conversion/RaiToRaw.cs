using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class RaiToRawRequest : IRPCAction
  {
    public string Action { get; } = "rai_to_raw";

    public string Amount { get; set; }
  }
}
