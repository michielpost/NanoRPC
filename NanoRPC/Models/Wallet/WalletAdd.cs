using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletAddRequest : IRPCAction
  {
    public string Action { get; } = "wallet_add";

    public string Wallet { get; set; }

    public string Key { get; set; }

    /// <summary>
    /// Optional Disables work generation after adding account
    /// </summary>
    public bool? Work { get; set; }
  }

  public class WalletAddResponse
  {
    public string Account { get; set; }
  }
}
