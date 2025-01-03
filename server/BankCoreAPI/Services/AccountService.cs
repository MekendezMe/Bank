using BankCoreAPI.DTOs.Account;
using BankCoreAPI.Interfaces;
using BankCoreAPI.Responses;

namespace BankCoreAPI.Services
{
    public class AccountService : IAccountService
    {
        public Task<IEnumerable<AccountDTO>> GetAccountsByUserIdAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDTO> OpenAccountAsync(AccountOpenerDTO account)
        {
            throw new NotImplementedException();
        }

        public Task<DepositResponse> TransferMoneyAccountAsync(AccountTransferDTO account)
        {
            throw new NotImplementedException();
        }
    }
}
