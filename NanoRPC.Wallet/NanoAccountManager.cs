using Isopoh.Cryptography.Blake2b;
using Isopoh.Cryptography.SecureArray;
using NanoRPC.Wallet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet
{
  public class NanoAccountManager
  {
    private readonly INanoRPC api;
    private readonly string representative;
    private readonly string seed;
    
    public NanoAccountManager(INanoRPC api, string representative, string seed)
    {
      this.api = api;
      this.representative = representative;
      this.seed = seed;
    }

    private static byte[] HexStringToByteArray(string hex)
    {
      int NumberChars = hex.Length;
      byte[] bytes = new byte[NumberChars / 2];
      for (int i = 0; i < NumberChars; i += 2)
        bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
      return bytes;
    }

    public string GetPrivateKey(int index)
    {
      var seedBytes = HexStringToByteArray(seed);
      string indexHex = index.ToString("X8");
      var indexBytes = HexStringToByteArray(indexHex);

      var hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 32 }, SecureArray.DefaultCall);
      hasher.Update(seedBytes);
      hasher.Update(indexBytes);

      var hashAll = hasher.Finish();

      string hexPrivateKey = BitConverter.ToString(hashAll).Replace("-", "");

      return hexPrivateKey;
    }

    public string GetPublicKey(string privateKey)
    {
      var keyBytes = HexStringToByteArray(privateKey);

      var publicBytes = DerivePublicFromSecret(keyBytes);

      string hexPublic = BitConverter.ToString(publicBytes).Replace("-", "");

      return hexPublic;
    }

    private byte[] DerivePublicFromSecret(byte[] sk)
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

   

    public string GetAddress(string publicKey)
    {
      var keyBytes = HexStringToByteArray(publicKey);
      var checksumBytes = Blake2B.ComputeHash(keyBytes, new Blake2BConfig() { OutputSizeInBytes = 5 }, SecureArray.DefaultCall);
      checksumBytes = checksumBytes.Reverse().ToArray();

      var checksum = NanoBase32Encoding.BytesToBase32(checksumBytes);
      var c_account = NanoBase32Encoding.BytesToBase32(keyBytes);

      return "nano_" + c_account + checksum;
    }

    public AccountInfo GetAddress(int index)
    {
      var privateKey = GetPrivateKey(index);
      var publicKey = GetPublicKey(privateKey);
      var address = GetAddress(publicKey);

      AccountInfo info = new AccountInfo
      {
        Index = index,
        Account = address,
        Private = privateKey,
        Public = publicKey
      };

      return info;
    }

    public IEnumerable<AccountInfo> GetAddress(Range range)
    {
      List<AccountInfo> result = new List<AccountInfo>();
      foreach (var r in range)
        result.Add(GetAddress(r));

      return result;
    }

    public NanoWallet GetNanoWallet(int index)
    {
      var accountInfo = GetAddress(index);

      return new NanoWallet(api, representative, accountInfo);
    }


    public async Task<AccountsBalancesResponse> GetBalancesAsync(Range range)
    {
      var accounts = GetAddress(range).Select(x => x.Account).ToList();
      return await api.AccountsBalances(new AccountsBalancesRequest() { Accounts = accounts });
    }

    public Task<AccountsPendingResponse> GetPendingTransactionsAsync(Range range)
    {
      var accounts = GetAddress(range).Select(x => x.Account).ToList();
      return api.AccountsPending(new AccountsPendingRequest { Accounts = accounts });
    }

  }
}
