using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PasswordChangeRequest : IRPCAction
  {
    public string Action { get; } = "password_change";

    public string Wallet { get; set; }

    public string Password { get; set; }

  }

  public class PasswordChangeResponse
  {
    public string Changed { get; set; }
  }
}
