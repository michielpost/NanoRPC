using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet
{
  public static class Utils
  {
    public static byte[] HexStringToByteArray(string hex)
    {
      int NumberChars = hex.Length;
      byte[] bytes = new byte[NumberChars / 2];
      for (int i = 0; i < NumberChars; i += 2)
        bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
      return bytes;
    }

    public static string Slice(this string source, int start, int end)
    {
      if (end < 0) // Keep this for negative end support
      {
        end = source.Length + end;
      }
      int len = end - start;               // Calculate length
      return source.Substring(start, len); // Return Substring of length
    }
  }
}
