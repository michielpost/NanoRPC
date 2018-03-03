using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountKeyRequest : IRPCAction
  {
    public string Action { get; } = "account_key";

    public string Account { get; set; }
  }

  public class AccountKeyResponse
  {
    public string Key { get; set; }

  }
}
