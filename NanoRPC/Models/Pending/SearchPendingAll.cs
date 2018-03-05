using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class SearchPendingAllRequest : IRPCAction
  {
    public string Action { get; } = "search_pending_all";
  }

  public class SearchPendingAllResponse
  {
    public string Success { get; set; }
  }
}
