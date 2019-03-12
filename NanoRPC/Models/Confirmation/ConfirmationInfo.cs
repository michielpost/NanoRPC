using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class ConfirmationInfoRequest : IRPCAction
  {
    public string Action { get; } = "confirmation_info";
    public string Root { get; set; }
    public bool? Json_block { get; set; }

  }

  public class ConfirmationInfoResponse
  {
    public string Announcements { get; set; }
    public string Last_winner { get; set; }
    public string Total_tally { get; set; }

    public Dictionary<string, string> Blocks { get; set; }

  }

}
