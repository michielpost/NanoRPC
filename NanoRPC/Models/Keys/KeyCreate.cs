using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class KeyCreateRequest : IRPCAction
  {
    public string Action { get; } = "key_create";
  }

  public class KeyCreateResponse
  {
    public string Private { get; set; }
    public string Public { get; set; }
    public string Account { get; set; }
  }
}
