using NanoRPC.Models;
using Refit;
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
  }

  public class WorkValidateResponse
  {
    public string Valid { get; set; }
  }
}
