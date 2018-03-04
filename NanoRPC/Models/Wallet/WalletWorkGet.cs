using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletWorkGetRequest : IRPCAction
  {
    public string Action { get; } = "wallet_work_get";

    public string Wallet { get; set; }

  }

  public class WalletWorkGetResponse
  {
    public Dictionary<string, string> Works { get; set; }
  }
}
