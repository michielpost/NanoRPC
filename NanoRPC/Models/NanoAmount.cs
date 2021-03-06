using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace NanoRPC
{
  /// <summary>
  /// Represents an amount of Nano currency
  /// Based on: https://github.com/Flufd/NanoDotNet/blob/master/NanoDotNet/Models/NanoAmount.cs
  /// </summary>
  [DebuggerDisplay("raw: {Raw}")]
  public struct NanoAmount
  {
    /// <summary>
    /// Creates a <see cref="NanoAmount"/> of the specified amount and base unit
    /// </summary>
    /// <param name="amount">The numerical value of the amount</param>
    /// <param name="amountBase">The base unit of the amount</param>
    public NanoAmount(BigInteger amount, AmountBase amountBase)
    {
      Raw = amount * BigInteger.Pow(10, (int)amountBase);
    }

    public NanoAmount(decimal amount, AmountBase amountBase)
    {
      decimal xrb = amount * Convert.ToDecimal(Math.Pow(10, (int)amountBase - (int)AmountBase.xrb));
      Raw = Convert.ToInt64(xrb) * BigInteger.Pow(10, (int)AmountBase.xrb);
    }

    /// <summary>
    /// Creates a <see cref="NanoAmount"/> of the specified amount and base unit
    /// </summary>
    /// <param name="amount">The numerical value of the amount</param>
    /// <param name="amountBase">The base unit of the amount</param>
    public NanoAmount(long amount, AmountBase amountBase)
    {
      Raw = amount * BigInteger.Pow(10, (int)amountBase);
    }


    /// <summary>
    /// The amount of Raw in the <see cref="NanoAmount"/>, this is the base amount for Nano
    /// </summary>
    public BigInteger Raw { get; private set; }

    public BigInteger ConvertTo(AmountBase amountBase)
    {
      return this.Raw / BigInteger.Pow(10, (int)amountBase);
    }

    public decimal ConvertToDecimal(AmountBase amountBase)
    {
      if (amountBase < AmountBase.xrb)
        throw new Exception("Only AmountBase.xrb and greater is supported");

      return (decimal)this.ConvertTo(AmountBase.xrb) / (decimal)BigInteger.Pow(10, (int)amountBase-(int)AmountBase.xrb);
    }

    public override string ToString()
    {
      return this.ToString(AmountBase.raw);
    }

    /// <summary>
    /// Format the amount in the specified base unit
    /// </summary>
    /// <param name="amountBase">The base unit to display the amount in</param>
    /// <returns></returns>
    public string ToString(AmountBase amountBase)
    {
      if (amountBase == AmountBase.raw)
      {
        return Raw.ToString();
      }

      // Get the string as raw
      var rawString = Raw.ToString();

      // How many zeros to add
      var zeros = new String('0', (int)amountBase);

      var appended = zeros + rawString;

      // Move the decimal up by the base unit
      var withDecimal = appended.Substring(0, appended.Length - (int)amountBase) + "." + appended.Substring(appended.Length - (int)amountBase);

      // Trim off leaing zeros and trailing zeros and decimal points
      var trimmed = withDecimal.TrimStart('0').TrimEnd('0').TrimEnd('.');

      if (trimmed.Length == 0)
      {
        return "0";
      }

      if (trimmed[0] == '.')
      {
        return "0" + trimmed;
      }

      return trimmed;
    }

    public static NanoAmount operator -(NanoAmount a, NanoAmount b) => new NanoAmount(a.Raw - b.Raw, AmountBase.raw);

    public static NanoAmount operator +(NanoAmount a, NanoAmount b) => new NanoAmount(a.Raw + b.Raw, AmountBase.raw);

    public static NanoAmount operator *(NanoAmount a, long b) => new NanoAmount(a.Raw * b, AmountBase.raw);
  }
}
