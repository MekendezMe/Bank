using BankCoreAPI.Core.Models.Accounts;

namespace BankCoreAPI.Core.Interfaces
{
    public interface IAccountTransactionRepository
    {
        Task<IEnumerable<AccountTransaction>> GetAccountTransactionsByAccountSenderIdAsync(long accountSenderId);

        Task<IEnumerable<AccountTransaction>> GetAccountTransactionsByAccountReceiverIdAsync(long accountReceiverId);

        Task<IEnumerable<AccountTransaction>> GetAccountTransactionsWithPositiveBalance();
    }
}
