using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class UncheckedClearRequest : IRPCAction
  {
    public string Action { get; } = "unchecked_clear";
  }

  public class UncheckedClearResponse
  {
    public string Success { get; set; }
  }
}
