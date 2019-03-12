using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class SignRequest : IRPCAction
  {
    public string Action { get; } = "sign";

    public string Block { get; set; }
    public string Key { get; set; }
    public bool? Json_block { get; set; }
  }

  public class SignResponse
  {
    public string Signature { get; set; }
    public string Block { get; set; }
  }
}
