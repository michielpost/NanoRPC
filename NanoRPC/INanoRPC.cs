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
    INanoUncheckedBlocksRPC,
    INanoWalletRPC
  {

    //TODO NEXT: Work cancel

    //TODO, wait for universal blocks: Offline signing(create block)

  }
}
