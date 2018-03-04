using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletRepresentativeSetRequest : IRPCAction
  {
    public string Action { get; } = "wallet_representative_set";

    public string Wallet { get; set; }

    public string Representative { get; set; }

  }

  public class WalletRepresentativeSetResponse
  {
    public string Set { get; set; }
  }
}
