using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PaymentInitRequest : IRPCAction
  {
    public string Action { get; } = "payment_init";

    public string Wallet { get; set; }
  }

  public class PaymentInitResponse
  {
    public string Status { get; set; }
  }
}
