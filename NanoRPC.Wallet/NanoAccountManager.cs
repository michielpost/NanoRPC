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
    private readonly string defaultRepresentative;
    private readonly string seed;
    private readonly string addressPrefix;

    public NanoAccountManager(INanoRPC api, string defaultRepresentative, string seed, string addressPrefix = "nano")
    {
      this.api = api;
      this.defaultRepresentative = defaultRepresentative;
      this.seed = seed;
      this.addressPrefix = addressPrefix;
    }

    

    public string GetPrivateKey(int index)
    {
      var seedBytes = Utils.HexStringToByteArray(seed);
      string indexHex = index.ToString("X8");
      var indexBytes = Utils.HexStringToByteArray(indexHex);

      var hasher = Blake2B.Create(new Blake2BConfig() { OutputSizeInBytes = 32 }, SecureArray.DefaultCall);
      hasher.Update(seedBytes);
      hasher.Update(indexBytes);

      var hashAll = hasher.Finish();

      string hexPrivateKey = BitConverter.ToString(hashAll).Replace("-", "");

      return hexPrivateKey;
    }

    public string GetPublicKey(string privateKey)
    {
      var keyBytes = Utils.HexStringToByteArray(privateKey);

      var publicBytes = Utils.DerivePublicFromSecret(keyBytes);

      string hexPublic = BitConverter.ToString(publicBytes).Replace("-", "");

      return hexPublic;
    }

    public string GetAddress(string publicKey)
    {
      var keyBytes = Utils.HexStringToByteArray(publicKey);
      var checksumBytes = Blake2B.ComputeHash(keyBytes, new Blake2BConfig() { OutputSizeInBytes = 5 }, SecureArray.DefaultCall);
      checksumBytes = checksumBytes.Reverse().ToArray();

      var checksum = NanoBase32Encoding.BytesToBase32(checksumBytes);
      var c_account = NanoBase32Encoding.BytesToBase32(keyBytes);

      return addressPrefix + "_" + c_account + checksum;
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

      return new NanoWallet(api, defaultRepresentative, accountInfo);
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
