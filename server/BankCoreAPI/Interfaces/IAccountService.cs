using BankCoreAPI.DTOs.Account;
using BankCoreAPI.Responses;

namespace BankCoreAPI.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<AccountDTO>> GetAccountsByUserIdAsync(long userId);

        Task<AccountDTO> OpenAccountAsync(AccountOpenerDTO account);

        Task<DepositResponse> TransferMoneyAccountAsync(AccountTransferDTO account);

        
    }
}
