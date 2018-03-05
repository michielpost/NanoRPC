using RestEase;
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
    Task<AccountBalanceResponse> AccountBalance([Body]AccountBalanceRequest req);

    /// <summary>
    /// Get number of blocks for a specific account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountBlockCountResponse> AccountBlockCount([Body]AccountBlockCountRequest req);

    /// <summary>
    /// enable_control required
    /// Creates a new account, insert next deterministic key in wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountCreateResponse> AccountCreate([Body]AccountCreateRequest req);

    /// <summary>
    /// Get account number for the public key
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountGetResponse> AccountGet([Body]AccountGetRequest req);

    /// <summary>
    /// Reports send/receive information for a account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountHistoryResponse> AccountHistory([Body]AccountHistoryRequest req);

    /// <summary>
    /// Returns frontier, open block, change representative block, balance, last modified timestamp from local database & block count for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountInfoResponse> AccountInfo([Body]AccountInfoRequest req);

    /// <summary>
    /// Lists all the accounts inside wallet
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountListResponse> AccountList([Body]AccountListRequest req);

    /// <summary>
    /// Moves accounts from source to wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountMoveResponse> AccountMove([Body]AccountMoveRequest req);

    /// <summary>
    /// Get the public key for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountKeyResponse> AccountKey([Body]AccountKeyRequest req);

    /// <summary>
    /// Remove account from wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountRemoveResponse> AccountRemove([Body]AccountRemoveRequest req);

    /// <summary>
    /// Returns the representative for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountRepresentativeResponse> AccountRepresentative([Body]AccountRepresentativeRequest req);

    /// <summary>
    /// Sets the representative for account in wallet
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountRepresentativeSetResponse> AccountRepresentativeSet([Body]AccountRepresentativeSetRequest req);

    /// <summary>
    /// Returns the voting weight for account
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountWeightResponse> AccountWeight([Body]AccountWeightRequest req);

    /// <summary>
    /// Returns how many RAW is owned and how many have not yet been received by accounts list
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsBalancesResponse> AccountsBalances([Body]AccountsBalancesRequest req);

    /// <summary>
    /// Creates new accounts, insert next deterministic keys in wallet up to count
    /// enable_control required
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsCreateResponse> AccountsCreate([Body]AccountsCreateRequest req);

    /// <summary>
    /// Returns a list of pairs of account and block hash representing the head block for accounts list
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsFrontiersResponse> AccountsFrontiers([Body]AccountsFrontiersRequest req);

    /// <summary>
    /// Returns a list of block hashes which have not yet been received by these accounts
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<AccountsPendingResponse> AccountsPending([Body]AccountsPendingRequest req);

    /// <summary>
    /// Check whether account is a valid account number
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ValidateAccountNumberResponse> ValidateAccountNumber([Body]ValidateAccountNumberRequest req);


  }
}
