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

    private List<AccountInfo> accountInfo = new List<AccountInfo>();

    public NanoAccountManager(INanoRPC api, string representative, string seed)
    {
      this.api = api;
      this.representative = representative;
      this.seed = seed;
    }

    public static byte[] HexStringToByteArray(string hex)
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

    public async Task<AccountInfo> GetAddressAsync(int index)
    {
      //Get from memory
      var existing = accountInfo.Where(x => x.Index == index).FirstOrDefault();
      if (existing != null)
        return existing;

      var apiResult = await api.DeterministicKey(new DeterministicKeyRequest() { Seed = seed, Index = index.ToString() });

      AccountInfo info = new AccountInfo
      {
        Index = index,
        Account = apiResult.Account,
        Private = apiResult.Private,
        Public = apiResult.Public
      };

      accountInfo.Add(info);

      return info;

    }

    public async Task<NanoWallet> GetNanoWallet(int index)
    {
      var accountInfo = await GetAddressAsync(index);

      return new NanoWallet(api, representative, accountInfo);
    }


    public async Task<AccountsBalancesResponse> GetBalancesAsync()
    {
      var accounts = accountInfo.Select(x => x.Account).ToList();
      return await api.AccountsBalances(new AccountsBalancesRequest() { Accounts = accounts });
    }

    public Task<AccountsPendingResponse> GetPendingTransactionsAsync()
    {
      var accounts = accountInfo.Select(x => x.Account).ToList();
      return api.AccountsPending(new AccountsPendingRequest { Accounts = accounts });
    }

  }
}
