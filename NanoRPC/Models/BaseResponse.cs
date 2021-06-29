using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Models
{
  public abstract class BaseResponse
  {
    public string? Error { get; set; }
  }
}
