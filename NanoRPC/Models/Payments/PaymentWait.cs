using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PaymentWaitRequest : IRPCAction
  {
    public string Action { get; } = "payment_wait";

    public string Account { get; set; }
    public string Amount { get; set; }

    /// <summary>
    /// Miliseconds
    /// </summary>
    public string Timeout { get; set; }
  }

  public class PaymentWaitResponse
  {
    public string Status { get; set; }
  }
}
