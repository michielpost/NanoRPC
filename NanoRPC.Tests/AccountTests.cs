using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NanoRPC.Tests
{
  [TestClass]
  public class AccountTests
  {
    private INanoRPC _client;
    private string _existingAccount = "nano_1po1s1x99geupxutnjezdwptbejutrzoot78b6xdfecqmremzj4qnweg7yff";

    private string _testAccount = "nano_1cyca8x1u4bdi3m6aqjx1ouwayrnais7aucc33w9zxdtrwqaoxdt8yfdzm94";
    private string _testWallet = "";
    private string _testPublicKey = "2BCA41BA0D892B8066445E3D0577C47B144432546D4A08787FF57AC72E8AF57A";

    public AccountTests()
    {
      _client = NanoClient.GetClient(Configuration.BaseUrl);
    }


    [TestMethod]
    public async Task AccountBalance()
    {
      var result = await _client.AccountBalance(new AccountBalanceRequest() { Account = _existingAccount });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Balance);
    }

    [TestMethod]
    public async Task AccountBlockCount()
    {
      var result = await _client.AccountBlockCount(new AccountBlockCountRequest() { Account = _existingAccount });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Block_Count);
    }

    [TestMethod]
    public async Task AccountCreate()
    {
      var result = await _client.AccountCreate(new AccountCreateRequest() { Wallet = _testWallet });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Account);
    }

    [TestMethod]
    public async Task AccountGet()
    {
      var result = await _client.AccountGet(new AccountGetRequest() { Key = _testPublicKey });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Account);
      Assert.AreEqual(_testAccount, result.Account);
    }

    [TestMethod]
    public async Task AccountHistory()
    {
      AccountHistoryResponse result = await _client.AccountHistory(new AccountHistoryRequest()
      {
        Account = _existingAccount,
        Count = "10"
      });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.History);
      Assert.IsTrue(result.History.Count == 10);
    }

    //[TestMethod]
    //public async Task AccountKey()
    //{
    //  var result = await _client.AccountKey(new AccountKeyRequest() { Account = _testAccount });

    //  Assert.IsNotNull(result);
    //  Assert.IsNotNull(result.Key);
    //  Assert.AreEqual(_testPublicKey, result.Key);

    //}

    //[TestMethod]
    //public async Task AccountList()
    //{
    //  var result = await _client.AccountList(new AccountListRequest() {  Wallet = _testPrivateKey });

    //  Assert.IsNotNull(result);
    //  Assert.IsNotNull(result.Accounts);
    //}

    [TestMethod]
    public async Task AccountsFrontiers()
    {
      var result = await _client.AccountsFrontiers(new AccountsFrontiersRequest() { Accounts = new List<string>() { _existingAccount } });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Frontiers);
    }

    [TestMethod]
    public async Task AccountRepresentative()
    {
      var result = await _client.AccountRepresentative(new AccountRepresentativeRequest() { Account = _existingAccount });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Representative);
    }

    [TestMethod]
    public async Task AccountWeight()
    {
      var result = await _client.AccountWeight(new AccountWeightRequest() { Account = _existingAccount });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Weight);
    }

    [TestMethod]
    public async Task ValidateAccountNumber()
    {
      var result = await _client.ValidateAccountNumber(new ValidateAccountNumberRequest() { Account = _existingAccount });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Valid);
      Assert.AreEqual("1", result.Valid);
    }

    [TestMethod]
    public async Task ValidateAccountNumberInvalid()
    {
      var result = await _client.ValidateAccountNumber(new ValidateAccountNumberRequest() { Account = "nano_invalid" });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Valid);
      Assert.AreEqual("0", result.Valid);
    }

    [TestMethod]
    public async Task AccountsPending()
    {
      var result = await _client.AccountsPending(new AccountsPendingRequest() { Accounts = new List<string>() { _existingAccount } });

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.Blocks);
    }
  }
}
