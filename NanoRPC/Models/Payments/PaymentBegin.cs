using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PaymentBeginRequest : IRPCAction
  {
    public string Action { get; } = "payment_begin";

    public string Wallet { get; set; }
  }

  public class PaymentBeginResponse
  {
    public string Account { get; set; }
  }
}
