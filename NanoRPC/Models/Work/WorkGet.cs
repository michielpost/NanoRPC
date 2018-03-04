using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class WorkGetRequest : IRPCAction
  {
    public string Action { get; } = "work_get";

    public string Wallet { get; set; }

    public string Account { get; set; }
  }

  public class WorkGetResponse
  {
    public string Work { get; set; }
  }
}
