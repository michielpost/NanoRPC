using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class ConfirmationHistoryRequest : IRPCAction
  {
    public string Action { get; } = "confirmation_history";
  }

  public class ConfirmationHistoryResponse
  {
    public List<Confirmation> Confirmations { get; set; }
  }

  public class Confirmation
  {
    public string Hash { get; set; }
    public string Tally { get; set; }
  }
}
