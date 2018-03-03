using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class MraiToRawRequest : IRPCAction
  {
    public string Action { get; } = "mrai_to_raw";

    public string Amount { get; set; }
  }
}
