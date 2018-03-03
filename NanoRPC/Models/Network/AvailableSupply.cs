using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AvailableSupplyRequest : IRPCAction
  {
    public string Action { get; } = "available_supply";
  }

  public class AvailableSupplyResponse
  {
    public string Available { get; set; }
  }
}
