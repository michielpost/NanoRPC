using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class DeterministicKeyRequest : IRPCAction
  {
    public string Action { get; } = "deterministic_key";

    public string Seed { get; set; }
    public string Index { get; set; }
  }

  public class DeterministicKeyResponse
  {
    public string Private { get; set; }
    public string Public { get; set; }
    public string Account { get; set; }
  }
}
