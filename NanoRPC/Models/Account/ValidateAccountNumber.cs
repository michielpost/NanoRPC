using NanoRPC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class ValidateAccountNumberRequest : IRPCAction
  {
    public string Action { get; } = "validate_account_number";

    public string Account { get; set; }
  }

  public class ValidateAccountNumberResponse
  {
    /// <summary>
    /// 1 if valid, 0 if invalid
    /// </summary>
    public string Valid { get; set; }

  }
}
