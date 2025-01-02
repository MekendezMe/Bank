using BankCoreAPI.Core.Models.Cards;

namespace BankCoreAPI.Core.Interfaces
{
    public interface ICardTransactionRepository
    {
        Task<CardTransaction> GetCardTransactionsByCardSenderIdAsync(long cardSenderId);

        Task<CardTransaction> GetCardTransactionsByCardReceiverIdAsync(long cardReceiverId);

        Task<CardTransaction> GetCardTransactionsWithPositiveBalance();
    }
}
