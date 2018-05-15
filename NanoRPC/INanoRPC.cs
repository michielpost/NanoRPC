using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  /// <summary>
  /// RPC based on https://github.com/nanocurrency/raiblocks/wiki/RPC-protocol
  /// </summary>
  public interface INanoRPC : INanoAccountRPC,
    INanoBlockRPC,
    INanoBootstrapRPC,
    INanoConfirmationsRPC,
    INanoConversionsRPC,
    INanoDelegatorsRPC,
    INanoFrontiersRPC,
    INanoKeysRPC,
    INanoLedgerRPC,
    INanoNetworkRPC,
    INanoNodeRPC,
    INanoPaymentsRPC,
    INanoPeersRPC,
    INanoPendingRPC,
    INanoReceivingRPC,
    INanoRepresentativesRPC,
    INanoSendRPC,
    INanoStatsRPC,
    INanoUncheckedBlocksRPC,
    INanoWalletRPC,
    INanoWorkRPC
  {

    //TODO, wait for universal blocks: Offline signing(create block)
  }
}
