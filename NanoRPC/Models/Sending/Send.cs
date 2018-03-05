using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class SendRequest : IRPCAction
  {
    public string Action { get; } = "send";

    public string Wallet { get; set; }
    public string Source { get; set; }
    public string Destination { get; set; }
    public string Amount { get; set; }

    /// <summary>
    /// You can (and should) specify a unique id for each spend to provide idempotency. That means that if you call send two times with the same id, the second request won't send any additional Nano, and will return the first block instead. The id can be any string. This may be a required parameter in the future.
    /// If you accidentally reuse an id, the send will not go through(it will be seen as a duplicate request), so make sure your ids are unique! They must be unique per node, and are not segregated per wallet.
    /// Using the same id for requests with different parameters(wallet, source, destination, and amount) is undefined behavior and may result in an error in the future.
    /// </summary>
    [Required]
    public string Id { get; set; }

    /// <summary>
    /// Optional. Uses work value for block from external source
    /// </summary>
    public string Work { get; set; }

  }

  public class SendResponse
  {
    public string Block { get; set; }
  }
}
