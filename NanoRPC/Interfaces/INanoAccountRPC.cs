using Refit;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoAccountRPC
  {
    /// <summary>
    /// Returns how many RAW is owned and how many have not yet been received by account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountBalanceResponse> GetBalance(AccountBalanceRequest req);

    /// <summary>
    /// Get number of blocks for a specific account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountBlockCountResponse> GetBlockCount(AccountBlockCountRequest req);

    /// <summary>
    /// enable_control required
    /// Creates a new account, insert next deterministic key in wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountCreateResponse> CreateAccount(AccountCreateRequest req);

    /// <summary>
    /// Get account number for the public key
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountGetResponse> GetUser(AccountGetRequest req);

    /// <summary>
    /// Reports send/receive information for a account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountHistoryResponse> GetAccountHistory(AccountHistoryRequest req);

    /// <summary>
    /// Returns frontier, open block, change representative block, balance, last modified timestamp from local database & block count for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountInfoResponse> GetAccountInfo(AccountInfoRequest req);

    /// <summary>
    /// Lists all the accounts inside wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountListResponse> GetAccounts(AccountListRequest req);

    /// <summary>
    /// Moves accounts from source to wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountMoveResponse> MoveAccount(AccountMoveRequest req);

    /// <summary>
    /// Get the public key for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountKeyResponse> GetAccountKey(AccountKeyRequest req);

    /// <summary>
    /// Remove account from wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountRemoveResponse> RemoveAccount(AccountRemoveRequest req);

    /// <summary>
    /// Returns the representative for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountRepresentativeResponse> GetAccountRepresentative(AccountRepresentativeRequest req);

    /// <summary>
    /// Sets the representative for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountRepresentativeSetResponse> SetAccountRepresentative(AccountRepresentativeSetRequest req);

    /// <summary>
    /// Returns the voting weight for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountWeightResponse> GetAccountWeight(AccountWeightRequest req);

    /// <summary>
    /// Returns how many RAW is owned and how many have not yet been received by accounts list
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsBalancesResponse> GetAccountsBalances(AccountsBalancesRequest req);

    /// <summary>
    /// Creates new accounts, insert next deterministic keys in wallet up to count
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsCreateResponse> CreateAccounts(AccountsCreateRequest req);

    /// <summary>
    /// Returns a list of pairs of account and block hash representing the head block for accounts list
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsFrontiersResponse> GetAccountsFrontiers(AccountsFrontiersRequest req);

    /// <summary>
    /// Returns a list of block hashes which have not yet been received by these accounts
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsPendingResponse> GetAccountsPending(AccountsPendingRequest req);


  }
}
