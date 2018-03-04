using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ReceiveRequest : IRPCAction
  {
    public string Action { get; } = "receive";

    public string Wallet { get; set; }
    public string Account { get; set; }
    public string Block { get; set; }
  }

  public class ReceiveResponse
  {
    public string Block { get; set; }
  }
}
