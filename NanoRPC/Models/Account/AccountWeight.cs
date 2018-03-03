using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountWeightRequest : IRPCAction
  {
    public string Action { get; } = "account_weight";

    public string Account { get; set; }
  }

  public class AccountWeightResponse
  {
    public string Weight { get; set; }

  }
}
