using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class HistoryRequest : IRPCAction
  {
    public string Action { get; } = "history";

    public string Hash { get; set; }
    public string Count { get; set; }
  }

  public class HistoryResponse
  {
    public List<History> History { get; set; }
  }

  public class History
  {
    public string Hash { get; set; }
    public string Type { get; set; }
    public string Account { get; set; }
    public string Amount { get; set; }
  }
}
