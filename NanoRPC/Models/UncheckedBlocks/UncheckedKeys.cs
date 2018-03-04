using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class UncheckedKeysRequest : IRPCAction
  {
    public string Action { get; } = "unchecked_keys";

    public string Keys { get; set; }
    public string Count { get; set; }
  }

  public class UncheckedKeysResponse
  {
    public List<UncheckedKey> Unchecked { get; set; }
  }

  public class UncheckedKey
  {
    public string Key { get; set; }
    public string Hash { get; set; }
    public string Contents { get; set; }
  }
}
