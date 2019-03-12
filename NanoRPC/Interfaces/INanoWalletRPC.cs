using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoWalletRPC
  {
    /// <summary>
    /// Add an adhoc private key key to wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletAddResponse> WalletAdd([Body]WalletAddRequest req);

    /// <summary>
    /// Add watch-only accounts to wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletAddWatchResponse> WalletAddWatch([Body]WalletAddWatchRequest req);

    /// <summary>
    /// Returns the sum of all accounts balances in wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletInfoResponse> WalletInfo([Body]WalletInfoRequest req);

    /// <summary>
    /// Returns how many rai is owned and how many have not yet been received by all accounts in wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletBalancesResponse> WalletBalances([Body]WalletBalancesRequest req);

    /// <summary>
    /// Changes seed for wallet to seed
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletChangeSeedResponse> WalletChangeSeed([Body]WalletChangeSeedRequest req);

    /// <summary>
    /// Check whether wallet contains account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletContainsResponse> WalletContains([Body]WalletContainsRequest req);

    /// <summary>
    /// Creates a new random wallet id
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletCreateResponse> WalletCreate([Body]WalletCreateRequest req);

    /// <summary>
    /// Destroys wallet and all contained accounts
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task WalletDestroy([Body]WalletDestroyRequest req);

    /// <summary>
    /// Return a json representation of wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletExportResponse> WalletExport([Body]WalletExportRequest req);

    /// <summary>
    /// Returns a list of pairs of account and block hash representing the head block starting for accounts from wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletFrontiersResponse> WalletFrontiers([Body]WalletFrontiersRequest req);

    /// <summary>
    /// Returns a list of block hashes which have not yet been received by accounts in this wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletPendingResponse> WalletPending([Body]WalletPendingRequest req);

    /// <summary>
    /// Rebroadcast blocks for accounts from wallet starting at frontier down to count to the network
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletRepublishResponse> WalletRepublish([Body]WalletRepublishRequest req);

    /// <summary>
    /// Returns a list of pairs of account and work from wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletWorkGetResponse> WalletWorkGet([Body]WalletWorkGetRequest req);

    /// <summary>
    /// Changes the password for wallet to password
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PasswordChangeResponse> PasswordChange([Body]PasswordChangeRequest req);

    /// <summary>
    /// Enters the password in to wallet (unlock wallet)
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PasswordEnterResponse> PasswordEnter([Body]PasswordEnterRequest req);

    /// <summary>
    /// Checks whether the password entered for wallet is valid
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<PasswordValidResponse> PasswordValid([Body]PasswordValidRequest req);

    /// <summary>
    /// enable_control required, version 11.0+
    /// Returns frontier, open block, change representative block, balance, last modified timestamp from local database & block count for accounts from wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletLedgerResponse> WalletLedger([Body]WalletLedgerRequest req);

    /// <summary>
    /// Locks wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletLockResponse> WalletLock([Body]WalletLockRequest req);

    /// <summary>
    /// Checks whether wallet is locked
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletLockedResponse> WalletLocked([Body]WalletLockedRequest req);

    /// <summary>
    /// Reports send/receive information for accounts in wallet. Change blocks are skipped, open blocks will appear as receive. Response will start with most recent blocks according to local ledger. 
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<WalletHistoryResponse> WalletHistory([Body]WalletHistoryRequest req);


  }
}
