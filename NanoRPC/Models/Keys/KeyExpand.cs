using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class KeyExpandRequest : IRPCAction
  {
    public string Action { get; } = "key_expand";

    public string Key { get; set; }
  }

  public class KeyExpandResponse
  {
    public string Private { get; set; }
    public string Public { get; set; }
    public string Account { get; set; }
  }
}
