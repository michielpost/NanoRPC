using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletCreateRequest : IRPCAction
  {
    public string Action { get; } = "wallet_create";

  }

  public class WalletCreateResponse
  {
    public string Wallet { get; set; }
  }
}
