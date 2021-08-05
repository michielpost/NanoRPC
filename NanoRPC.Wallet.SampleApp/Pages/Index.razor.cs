using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace NanoRPC.Wallet.SampleApp.Pages
{
  public partial class Index
  {
    private NanoAccountManager manager;
    private NanoWallet wallet;
    private INanoRPC api;

    private const string defaultRepresentative = "nano_34zuxqdsucurhjrmpc4aixzbgaa4wjzz6bn5ryn56emc9tmd3pnxjoxfzyb6";
    //private const string defaultRepresentative = "ban_1nano4cqttsbdo5nwttfse8h3oaxickjwq4qobqphg7hifbcauaokz9q6ugj";

    /// <summary>
    /// For BANANO use https://kaliumapi.appditto.com/api
    /// </summary>
    public string ApiBase { get; set; } = "https://nault.nanos.cc/proxy"; 
    public string Seed { get; set; }
    public string WalletIndex { get; set; } = "0";
    public string Address { get; set; }
    public byte[] QR { get; set; }
    public AccountBalanceResponse Balance { get; set; }
    public PendingResponse Pending { get; set; }
    public AccountHistoryResponse History { get; set; }

    public string ToAddress { get; set; } = "nano_14ezmbmoj5zqzoj7g99bec1rfr7woe1d7bsa87wmsbfpt4u4mnur8183oqtm"; //Default NanoRPC donation address :)
    public string ToAmount { get; set; }

    public async Task RandomSeed()
    {
      Seed = RandomHexString();
      await LoadWallet();
    }

    private static string RandomHexString()
    {
      // 64 character precision or 256-bits
      string hexValue = string.Empty;
      int num;

      for (int i = 0; i < 8; i++)
      {
        num = RandomNumberGenerator.GetInt32(0, int.MaxValue);
        hexValue += num.ToString("X8");
      }

      return hexValue.ToUpperInvariant();
    }

    public async Task LoadWallet()
    {
      //Reset
      Address = null;
      Balance = null;
      Pending = null;
      History = null;

      var i = int.Parse(WalletIndex);

      api = NanoClient.GetClient(ApiBase);
      manager = new NanoAccountManager(api, defaultRepresentative, Seed);
      wallet = manager.GetNanoWallet(i);

      await LoadWalletInfo();
    }

    private async Task LoadWalletInfo()
    {
      Address = wallet.Account;

      GenerateQRcode(Address);

      Balance = await wallet.GetBalanceAsync();

      Pending = await wallet.GetPendingTransactionsAsync();

      History = await wallet.GetTransactionsAsync(3);
    }

    private void GenerateQRcode(string address)
    {
      QRCodeGenerator qrGenerator = new QRCodeGenerator();
      QRCodeData qrCodeData = qrGenerator.CreateQrCode($"nano:{address}", QRCodeGenerator.ECCLevel.Q);
      PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
      QR = qrCode.GetGraphic(20);
    }

    public async Task ProcessPending()
    {
     await wallet.ProcessPendingTransactionsAsync();

      await LoadWalletInfo();

    }

    public async Task SendNano()
    {
      var raw = BigInteger.Parse(ToAmount);
      var amount = new NanoAmount(raw, AmountBase.raw);

      await wallet.SendNano(ToAddress, amount);

      await LoadWalletInfo();

    }

    public async Task SendAllNano()
    {
      await wallet.SendNano(ToAddress, Balance.Balance);

      await LoadWalletInfo();

    }
  }
}
