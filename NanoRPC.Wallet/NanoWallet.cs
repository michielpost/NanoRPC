using NanoRPC.Wallet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NanoRPC.Wallet
{
  public class NanoWallet
  {
    private readonly INanoRPC api;
    private readonly string representative;
    private readonly AccountInfo accountInfo;

    public string Account => accountInfo.Account;

    public NanoWallet(INanoRPC api, string representative, AccountInfo accountInfo)
    {
      this.api = api;
      this.representative = representative;
      this.accountInfo = accountInfo;
    }


    public Task<AccountBalanceResponse> GetBalanceAsync()
    {
      return api.AccountBalance(new AccountBalanceRequest() { Account = accountInfo.Account });
    }

    public Task<AccountInfoResponse> GetAccountInfoAsync()
    {
      return api.AccountInfo(new AccountInfoRequest() { Account = accountInfo.Account, Representative = true });
    }

    public Task<AccountHistoryResponse> GetTransactionsAsync(int count = 1)
    {
      return api.AccountHistory(new AccountHistoryRequest() { Account = accountInfo.Account, Count = count.ToString() });

    }

    public async Task<PendingResponse> GetPendingTransactionsAsync()
    {
      return await api.Pending(new PendingRequest {  Account = accountInfo.Account });
    }

    public Task<BlockCreateResponse> CreateReceiveTransactionAsync(
      NanoAmount amount,
      string receiveHash,
      string? currentRepresentative = null,
      string? previousHash = null)
    {
      BlockCreateRequest block = new BlockCreateRequest
      {
        Account = accountInfo.Account,
        Balance = amount,
        Key = accountInfo.Private,
        Link = receiveHash,
        Previous = previousHash ?? "0",
        Representative = currentRepresentative ?? representative
      };

      return api.BlockCreate(block);
    }

    public async Task<List<string>> ProcessPendingTransactions()
    {
      List<string> result = new List<string>();

      var pending = await GetPendingTransactionsAsync();

      if(pending.Blocks.Any())
      {
        foreach (var block in pending.Blocks)
        {
          var hash = await ProcessPendingTransactionsAsync(block.Key, block.Value);
          result.Add(hash);
        }
      }

      return result;
    }

    private async Task<string> ProcessPendingTransactionsAsync(string receiveBlockHash, NanoAmount amount)
    {
      var currentAccountInfo = await GetAccountInfoAsync();

      var newAmount = currentAccountInfo.Balance + amount;

      var block = await CreateReceiveTransactionAsync(newAmount, receiveBlockHash, currentAccountInfo.Representative, currentAccountInfo.Frontier);

      //Send block
      var subType = "receive";
      if (currentAccountInfo.Open_Block == null)
        subType = "open";

      var result = await api.Process(new ProcessRequest() { SubType = subType, Block = block.Block });
      await WaitForConfirm(result.Hash);

      return result.Hash;

    }

    public async Task<string> SendNano(string toAccount, NanoAmount amount)
    {
      var currentAccountInfo = await GetAccountInfoAsync();

      var newAmount = currentAccountInfo.Balance - amount;

      var block = await CreateReceiveTransactionAsync(newAmount, toAccount, currentAccountInfo.Representative, currentAccountInfo.Frontier);

      //Send block
      var result = await api.Process(new ProcessRequest() { SubType = "send", Block = block.Block });
      await WaitForConfirm(result.Hash);


      return result.Hash;
    }

    public async Task<bool> WaitForConfirm(string hash, TimeSpan? timeSpan = null)
    {
      var cts = new CancellationTokenSource();

      var tryTask = TryConfirm(hash, cts.Token);
      timeSpan = timeSpan ?? TimeSpan.FromSeconds(30);

      await Task.WhenAny(tryTask, Task.Delay(timeSpan.Value, cts.Token));

      if (tryTask.IsCompleted && await tryTask)
        return true;
      else
        throw new TimeoutException($"Block did not confirm in time. {hash}");
    }

    private async Task<bool> TryConfirm(string hash, CancellationToken token)
    {
      while(!token.IsCancellationRequested)
      {
        var blockInfo = await api.BlockInfo(new BlockInfoRequest() { Hash = hash });
        if (blockInfo.Confirmed)
          return true;
        else
          await Task.Delay(TimeSpan.FromSeconds(2), token);
      }

      return false;
    }

   
  }
}
