using NanoRPC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC
{
  public class PasswordValidRequest : IRPCAction
  {
    public string Action { get; } = "password_valid";

    public string Wallet { get; set; }
  }

  public class PasswordValidResponse
  {
    public string Changed { get; set; }
  }
}
