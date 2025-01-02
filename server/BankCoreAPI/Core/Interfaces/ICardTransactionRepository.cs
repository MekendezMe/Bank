using BankCoreAPI.Core.Models.Cards;

namespace BankCoreAPI.Core.Interfaces
{
    public interface ICardTransactionRepository
    {
        Task<IEnumerable<CardTransaction>> GetCardTransactionsByCardSenderIdAsync(long cardSenderId);

        Task<IEnumerable<CardTransaction>> GetCardTransactionsByCardReceiverIdAsync(long cardReceiverId);

        Task<IEnumerable<CardTransaction>> GetCardTransactionsWithPositiveBalance();
    }
}
