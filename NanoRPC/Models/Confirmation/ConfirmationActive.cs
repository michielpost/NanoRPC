using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class ConfirmationActiveRequest : IRPCAction
  {
    public string Action { get; } = "confirmation_active";

    /// <summary>
    /// Optional Number, 0 by default. Returns only active elections with equal or higher announcements count. Useful to find long running elections
    /// </summary>
    public int? Announcements { get; set; }

  }

  public class ConfirmationActiveResponse
  {
    public List<string> Confirmations { get; set; }
  }

}
