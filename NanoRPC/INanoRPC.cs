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
    INanoPaymentsRPC
  {

    //TODO NEXT: Payment Init

    //TODO, wait for universal blocks: Offline signing(create block)

  }
}
