using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class SearchPendingRequest : IRPCAction
  {
    public string Action { get; } = "search_pending";

    public string Wallet { get; set; }
  }

  public class SearchPendingResponse
  {
    public string Started { get; set; }
  }
}
