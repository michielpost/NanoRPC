using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PasswordEnterRequest : IRPCAction
  {
    public string Action { get; } = "password_enter";

    public string Wallet { get; set; }

    public string Password { get; set; }

  }

  public class PasswordEnterResponse
  {
    public string Valid { get; set; }
  }
}
