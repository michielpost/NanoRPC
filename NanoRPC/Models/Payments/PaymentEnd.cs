using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PaymentEndRequest : IRPCAction
  {
    public string Action { get; } = "payment_end";

    public string Account { get; set; }
    public string Wallet { get; set; }
  }
}
