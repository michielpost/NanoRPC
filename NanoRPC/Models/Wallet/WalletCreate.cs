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

    /// <summary>
    /// Optional Seed value (64 hexadecimal digits string, 256 bit). Changes seed for a new wallet to seed, returning last restored account from given seed & restored count
    /// </summary>
    public string Seed { get; set; }

  }

  public class WalletCreateResponse
  {
    public string Wallet { get; set; }
  }
}
