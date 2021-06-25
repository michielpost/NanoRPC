using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet.Models
{
  public record AccountInfo
  {
    public int Index { get; set; }
    public string Private { get; set; }
    public string Public { get; set; }
    public string Account { get; set; }
  }
}
