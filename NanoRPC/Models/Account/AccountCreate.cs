using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountCreateRequest : IRPCAction
  {
    public string Action { get; } = "account_create";

    public string Wallet { get; set; }

    public bool? Work { get; set; }

    public string Index { get; set; }
  }

  public class AccountCreateResponse
  {
    public string Account { get; set; }
  }
}
