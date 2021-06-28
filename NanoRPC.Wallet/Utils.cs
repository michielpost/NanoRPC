using Isopoh.Cryptography.Blake2b;
using Isopoh.Cryptography.SecureArray;
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

    public static byte[] DerivePublicFromSecret(byte[] sk)
    {
      Int32 GF_LEN = 16;

      Int64[][] /*gf*/ p = new Int64[4][] { new Int64[GF_LEN], new Int64[GF_LEN], new Int64[GF_LEN], new Int64[GF_LEN] };
      var pk = new byte[32];

      var hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 64 }, SecureArray.DefaultCall);
      hasher.Update(sk);
      var d = hasher.Finish();

      d[0] &= 248;
      d[31] &= 127;
      d[31] |= 64;

      TweetNaCl.TweetNaCl.Scalarbase(p, d, 0);
      TweetNaCl.TweetNaCl.Pack(pk, p);

      return pk;
    }

    public static byte[] CryptoSign(byte[] m, byte[] sk)
    {
      byte[] sm = new byte[64 + m.Length];
      var n = m.Length;
      var h = new byte[64];

      var x = new long[64];

      Int32 GF_LEN = 16;

      Int64[][] /*gf*/ p = new Int64[4][] { new Int64[GF_LEN], new Int64[GF_LEN], new Int64[GF_LEN], new Int64[GF_LEN] };

      var pk = Utils.DerivePublicFromSecret(sk);

      var hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 64 }, SecureArray.DefaultCall);
      hasher.Update(sk);
      var d = hasher.Finish();

      d[0] &= 248;
      d[31] &= 127;
      d[31] |= 64;

      var smlen = n + 64;
      for (int i = 0; i < n; i++) sm[64 + i] = m[i];
      for (int i = 0; i < 32; i++) sm[32 + i] = d[32 + i];

      hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 64 }, SecureArray.DefaultCall);
      hasher.Update(sm[32..]);
      var r = hasher.Finish();

      TweetNaCl.TweetNaCl.Reduce(r);
      TweetNaCl.TweetNaCl.Scalarbase(p, r, 0);
      TweetNaCl.TweetNaCl.Pack(sm, p);

      for (int i = 32; i < 64; i++) sm[i] = pk[i - 32];

      hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 64 }, SecureArray.DefaultCall);
      hasher.Update(sm);
      h = hasher.Finish();

      TweetNaCl.TweetNaCl.Reduce(h);

      for (int i = 0; i < 64; i++) x[i] = 0;
      for (int i = 0; i < 32; i++) x[i] = r[i];
      for (int i = 0; i < 32; i++)
      {
        for (int j = 0; j < 32; j++)
        {
          x[i + j] += h[i] * d[j];
        }
      }

      TweetNaCl.TweetNaCl.ModL(sm, 32, x);
      return sm;
    }
  }
}
