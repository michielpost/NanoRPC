using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class ConfirmationQuorumRequest : IRPCAction
  {
    public string Action { get; } = "confirmation_quorum";
    public bool? Peer_details { get; set; }

  }

  public class ConfirmationQuorumResponse
  {
    public string Quorum_delta { get; set; }
    public string Online_weight_quorum_percent { get; set; }
    public string Online_weight_minimum { get; set; }
    public string Online_stake_total { get; set; }
    public string Peers_stake_total { get; set; }
    public string Peers_stake_required { get; set; }

  }

}
