using BankCoreAPI.Core.Models.Accounts;

namespace BankCoreAPI.Core.Interfaces
{
    public interface IAccountTransactionRepository
    {
        Task<AccountTransaction> GetAccountTransactionsByAccountSenderIdAsync(long accountSenderId);

        Task<AccountTransaction> GetAccountTransactionsByAccountReceiverIdAsync(long accountReceiverId);

        Task<AccountTransaction> GetAccountTransactionsWithPositiveBalance();
    }
}
