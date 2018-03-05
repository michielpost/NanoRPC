using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountsCreateRequest : IRPCAction
  {
    public string Action { get; } = "accounts_create";

    public string Wallet { get; set; }

    public string Count { get; set; }

    /// <summary>
    /// Optional. Disables work generation after creating account
    /// </summary>
    public bool? Work { get; set; }
  }

  public class AccountsCreateResponse
  {
    public List<string> Accounts { get; set; }

  }
}
