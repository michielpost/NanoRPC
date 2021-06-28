using System;
using System.Linq;
using System.Text;


namespace NanoRPC.Wallet
{
  /// <summary>
  /// Nano-specific Byte32 encoding.
  /// Based on JS code from https://stackoverflow.com/a/42231034/460298.
  /// From C# port: https://github.com/justdmitry/NanoRpcSharp/blob/master/NanoRpcSharp/Util/NanoBase32Encoding.cs
  /// </summary>
  public static class NanoBase32Encoding
  {
    public const string Alphabet = "13456789abcdefghijkmnopqrstuwxyz";

    /// <summary>
    /// Convert byte array to base32 custom alphabet string.
    /// </summary>
    /// <param name="bytes">Source array.</param>
    /// <returns>Converted string.</returns>
    public static string BytesToBase32(ReadOnlySpan<byte> bytes)
    {
      var length = bytes.Length;
      var leftover = (length * 8) % 5;
      var offset = leftover == 0 ? 0 : 5 - leftover;

      var value = 0;
      var output = new StringBuilder(length); // more than needed, but OK for our goals
      var bits = 0;

      for (var i = 0; i < length; i++)
      {
        value = (value << 8) | bytes[i];
        bits += 8;

        while (bits >= 5)
        {
          output.Append(Alphabet[(value >> (bits + offset - 5)) & 31]);
          bits -= 5;
        }
      }

      if (bits > 0)
      {
        output.Append(Alphabet[(value << (5 - (bits + offset))) & 31]);
      }

      return output.ToString();
    }

    /// <summary>
    /// Convert base32 custom alphabet string into byte array.
    /// </summary>
    /// <param name="base32">Source string.</param>
    /// <returns>Converted byte array.</returns>
    public static Span<byte> Base32ToBytes(ReadOnlySpan<char> base32)
    {
      var length = base32.Length;
      var leftover = (length * 8) % 5;
      var offset = leftover == 0 ? 0 : 5 - leftover;

      int value = 0;
      var bits = 0;

      var index = 0;
      var output = new byte[(int)Math.Ceiling((float)length * 5 / 8)];

      for (var i = 0; i < length; i++)
      {
        value = (value << 5) | Alphabet.IndexOf(base32[i]);
        bits += 5;

        if (bits >= 8)
        {
          output[index++] = (byte)((value >> (bits + offset - 8)) & 255);
          bits -= 8;
        }
      }

      if (bits > 0)
      {
        output[index++] = (byte)((value << (bits + offset - 8)) & 255);
      }

      if (leftover == 0)
      {
        return output;
      }
      else
      {
        return output.AsSpan(1);
      }
    }
  }
}
