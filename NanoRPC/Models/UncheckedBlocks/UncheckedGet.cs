using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class UncheckedGetRequest : IRPCAction
  {
    public string Action { get; } = "unchecked_get";

    public string Hash { get; set; }
  }

  public class UncheckedGetResponse
  {
    public string Contents { get; set; }
  }
}
