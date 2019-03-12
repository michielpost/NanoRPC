using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkValidateRequest : IRPCAction
  {
    public string Action { get; } = "work_validate";

    public string Work { get; set; }
    public string Hash { get; set; }

    /// <summary>
    /// Optional Difficulty value (16 hexadecimal digits string, 64 bit). Uses difficulty value to validate work
    /// </summary>
    public string Difficulty { get; set; }

  }

  public class WorkValidateResponse
  {
    public string Valid { get; set; }
  }
}
