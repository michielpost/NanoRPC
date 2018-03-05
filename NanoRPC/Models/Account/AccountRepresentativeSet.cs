using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountRepresentativeSetRequest : IRPCAction
  {
    public string Action { get; } = "account_representative_set";

    public string Wallet { get; set; }
    public string Account { get; set; }
    public string Representative { get; set; }

    /// <summary>
    /// Optional, Uses work value for block from external source
    /// </summary>
    public string Block { get; set; }
  }

  public class AccountRepresentativeSetResponse
  {
    public string Block { get; set; }

  }
}
