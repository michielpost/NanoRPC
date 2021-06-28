using Isopoh.Cryptography.Blake2b;
using Isopoh.Cryptography.SecureArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NanoRPC.Wallet
{
  public static class BlockSigner
  {
    private static Regex accountpattern = new Regex("^(xrb_|nano_|ban_|lumo_|nos_|eur_|usd_)(1|3)[13456789abcdefghijkmnopqrstuwxyz]{59}$"); // accounts
    private static Regex hashpattern = new Regex("[0-9a-fA-F]{64}"); // hashes and pubkeys

    public static string HashBlock(BlockCreateRequest block)
    {
      var preable = "0000000000000000000000000000000000000000000000000000000000000006";
      var account = GetHashOrPublicKey(block.Account);
      var prev = block.Previous;
      var rep = GetHashOrPublicKey(block.Representative);
      var balance = block.Balance.Raw.ToString("X32");
      var link = GetHashOrPublicKey(block.Link);

      var hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 32 }, SecureArray.DefaultCall);
      hasher.Update(Utils.HexStringToByteArray(preable));
      hasher.Update(Utils.HexStringToByteArray(account));
      hasher.Update(Utils.HexStringToByteArray(prev));
      hasher.Update(Utils.HexStringToByteArray(rep));
      hasher.Update(Utils.HexStringToByteArray(balance));
      hasher.Update(Utils.HexStringToByteArray(link));

      var hashAll = hasher.Finish();

      var hash = BitConverter.ToString(hashAll).Replace("-", "");

      return hash;
    }

    public static string GetHashOrPublicKey(string account)
    {
      if (accountpattern.Matches(account).Count > 0)
        return GetPublicKey(account);
      else
        return account;
    }

    public static string SignHash(string hash, string privateKey)
    {
      var hashBytes = Utils.HexStringToByteArray(hash);
      var privateKeyBytes = Utils.HexStringToByteArray(privateKey);

      var sigBytes = CryptoSign(hashBytes, privateKeyBytes);

      var hex = BitConverter.ToString(sigBytes[..64]).Replace("-", "");

      return hex;
    }

    public static string GetPublicKey(string account)
    {
      if (account.Length < 60)
        throw new ArgumentOutOfRangeException(nameof(account));

      var account_crop = account.Substring(account .Length - 60);

      var keyBytes = NanoBase32Encoding.Base32ToBytes(account_crop.Substring(0, 52));
      var hashBytes = NanoBase32Encoding.Base32ToBytes(account_crop.Substring(52, 8));

      var blakeHash = Blake2B.ComputeHash(keyBytes.ToArray(), new Blake2BConfig() { OutputSizeInBytes = 5 }, SecureArray.DefaultCall);

      var key = BitConverter.ToString(keyBytes.ToArray()).Replace("-", "");

      return key;
    }

    private static byte[] CryptoSign(byte[] m, byte[] sk)
    {
      byte[] sm = new byte[64 + m.Length];
      var n = m.Length;
      var h = new byte[64];

      var x = new long[64];

      Int32 GF_LEN = 16;

      Int64[][] /*gf*/ p = new Int64[4][] { new Int64[GF_LEN], new Int64[GF_LEN], new Int64[GF_LEN], new Int64[GF_LEN] };

      var pk = NanoAccountManager.DerivePublicFromSecret(sk);

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

      TweetNaCl.TweetNaCl.ModL(sm[32..], 0, x);
      return sm;
    }
  }
}
