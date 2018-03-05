using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountGetRequest : IRPCAction
  {
    public string Action { get; } = "account_get";

    public string Key { get; set; }
  }

  public class AccountGetResponse
  {
    public string Account { get; set; }
  }
}
