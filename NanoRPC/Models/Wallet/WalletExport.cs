using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WalletExportRequest : IRPCAction
  {
    public string Action { get; } = "wallet_export";

    public string Wallet { get; set; }

  }

  public class WalletExportResponse
  {
    public string Json { get; set; }
  }
}
