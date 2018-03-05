using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletRepresentativeRequest : IRPCAction
  {
    public string Action { get; } = "wallet_representative";

    public string Wallet { get; set; }

  }

  public class WalletRepresentativeResponse
  {
    public string Representative { get; set; }
  }
}
