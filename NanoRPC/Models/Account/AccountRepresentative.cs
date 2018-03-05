using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class AccountRepresentativeRequest : IRPCAction
  {
    public string Action { get; } = "account_representative";

    public string Account { get; set; }
  }

  public class AccountRepresentativeResponse
  {
    public string Representative { get; set; }

  }
}
