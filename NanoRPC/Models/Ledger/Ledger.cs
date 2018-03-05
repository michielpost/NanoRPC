using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class LedgerRequest : IRPCAction
  {
    public string Action { get; } = "ledger";

    public string Account { get; set; }
    public string Count { get; set; }

    /// <summary>
    /// Additionally returns representative
    /// </summary>
    public bool? Representative { get; set; }

    /// <summary>
    /// Additionally returns voting weight
    /// </summary>
    public bool? Weight { get; set; }

    /// <summary>
    ///  Additionally returns pending balance for each account
    /// </summary>
    public bool? Pending { get; set; }
  }

  public class LedgerResponse
  {
    public Dictionary<string, Account> Accounts { get; set; }
  }

  public class Account
  {
    public string Frontier { get; set; }
    public string Open_Block { get; set; }
    public string Representative_Block { get; set; }
    public string Balance { get; set; }
    public string Modified_Timestamp { get; set; }
    public string Block_Count { get; set; }
    public string Representative { get; set; }
    public string Weight { get; set; }
    public string Pending { get; set; }

  }
}
