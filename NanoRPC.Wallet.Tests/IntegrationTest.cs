using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRPC.Wallet.Tests
{
  [TestClass]
  public class IntegrationTest
  {
    private NanoAccountManager manager;
    private INanoRPC api;
    private const string seed = "31310173082E376A949D1297660ACD7BF30A4F5DBAA16C4F545483FD511DCA32";
    private const string representative = "nano_34zuxqdsucurhjrmpc4aixzbgaa4wjzz6bn5ryn56emc9tmd3pnxjoxfzyb6";

    public IntegrationTest()
    {
      api = NanoClient.GetClient(Configuration.BaseUrl);
      manager = new NanoAccountManager(api, representative, seed);
    }

    private static string RandomHexString()
    {
      // 64 character precision or 256-bits
      Random rdm = new Random();
      string hexValue = string.Empty;
      int num;

      for (int i = 0; i < 8; i++)
      {
        num = rdm.Next(0, int.MaxValue);
        hexValue += num.ToString("X8");
      }

      return hexValue.ToUpperInvariant();
    }

    /// <summary>
    /// WARNING: Only run this on TESTNET
    /// </summary>
    /// <returns></returns>
    [TestMethod]
    public async Task RunIntegrationTest()
    {
      //Original account with some funds
      var originalWallet = manager.GetNanoWallet(0);

      await originalWallet.ProcessPendingTransactions();

      var originalBalance = await originalWallet.GetBalanceAsync();
      var originalNano = originalBalance.Balance;
      Assert.IsTrue(originalBalance.Balance.Raw > new NanoAmount(5, AmountBase.Nano).Raw, $"Send 5 TESTNET-NANO to {originalWallet.Account} for this test to run");

      //New and unused random account
      var randomSeed = RandomHexString();
      var newManager = new NanoAccountManager(api, representative, randomSeed);
      var newWallet = newManager.GetNanoWallet(0);

      //Assert: balance of fresh account should be 0
      var newBalance = await newWallet.GetBalanceAsync();
      Assert.AreEqual(0, newBalance.Balance.Raw);
      Assert.AreEqual(0, newBalance.Pending.Raw);

      var newAccount = await newWallet.GetAccountInfoAsync();
      Assert.IsNull(newAccount.Open_Block);

      //Send to new account
      var firstSendAmount = new NanoAmount(2, AmountBase.Nano);
      var hash = await originalWallet.SendNano(newWallet.Account, firstSendAmount);
      Assert.IsNotNull(hash);

      //Assert: balance decreased with original account
      var currentOriginalBalance = await originalWallet.GetBalanceAsync();
      Assert.AreEqual(originalNano - firstSendAmount, currentOriginalBalance.Balance);

      //Assert: pending balance is up with new account
      newBalance = await newWallet.GetBalanceAsync();
      Assert.AreEqual(0, newBalance.Balance.Raw);
      Assert.AreEqual(firstSendAmount.Raw, newBalance.Pending.Raw);

      //Assert: New account has 1 pending transaction
      var pendingNewWallet = await newWallet.GetPendingTransactionsAsync();
      Assert.AreEqual(1, pendingNewWallet.Blocks.Count);
      Assert.AreEqual(firstSendAmount.Raw, pendingNewWallet.Blocks.First().Value.Raw);

      //Process pending transaction (First transaction, opens account)
      var processResult = await newWallet.ProcessPendingTransactions();
      Assert.AreEqual(1, processResult.Count);

      //Assert: balance is up with new account
      newBalance = await newWallet.GetBalanceAsync();
      Assert.AreEqual(firstSendAmount.Raw, newBalance.Balance.Raw);
      Assert.AreEqual(0, newBalance.Pending.Raw);

      //Assert: no pending transactions
      pendingNewWallet = await newWallet.GetPendingTransactionsAsync();
      Assert.AreEqual(0, pendingNewWallet.Blocks.Count);

      //Send to new account TWICE
      var secondSendAmount = new NanoAmount(1, AmountBase.Nano);
      hash = await originalWallet.SendNano(newWallet.Account, secondSendAmount);
      Assert.IsNotNull(hash);

      var thirdSendAmount = new NanoAmount(2, AmountBase.Nano);
      hash = await originalWallet.SendNano(newWallet.Account, thirdSendAmount);
      Assert.IsNotNull(hash);

      //Assert: balance decreased with original account
      currentOriginalBalance = await originalWallet.GetBalanceAsync();
      Assert.AreEqual((originalNano - firstSendAmount - secondSendAmount - thirdSendAmount).Raw, currentOriginalBalance.Balance.Raw);

      //Assert: pending balance is up with new account
      newBalance = await newWallet.GetBalanceAsync();
      Assert.AreEqual(firstSendAmount.Raw, newBalance.Balance.Raw);
      Assert.AreEqual((secondSendAmount + thirdSendAmount).Raw, newBalance.Pending.Raw);

      //Assert: New account has 2 pending transactions
      pendingNewWallet = await newWallet.GetPendingTransactionsAsync();
      Assert.AreEqual(2, pendingNewWallet.Blocks.Count);

      //Process pending transactions
      processResult = await newWallet.ProcessPendingTransactions();
      Assert.AreEqual(2, processResult.Count);

      //Assert: balance is up with new account
      newBalance = await newWallet.GetBalanceAsync();
      Assert.AreEqual((firstSendAmount + secondSendAmount + thirdSendAmount).Raw, newBalance.Balance.Raw);
      Assert.AreEqual(0, newBalance.Pending.Raw);

      //Send ALL BACK to original account
      hash = await newWallet.SendNano(originalWallet.Account, newBalance.Balance);
      Assert.IsNotNull(hash);

      //Process on original account
      processResult = await originalWallet.ProcessPendingTransactions();
      Assert.AreEqual(1, processResult.Count);

      //Assert: original balance is back
      currentOriginalBalance = await originalWallet.GetBalanceAsync();
      Assert.AreEqual(originalNano.Raw, currentOriginalBalance.Balance.Raw);
    }
  }
}
