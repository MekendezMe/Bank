using BankCoreAPI.Core.Models.Cards;

namespace BankCoreAPI.Core.Interfaces
{
    public interface ICardRepository
    {
        Task<Card> GetCardByNumberAsync(string number);

        Task<IEnumerable<Card>> GetCardsByUserIdAsync(long userId);

        Task<IEnumerable<Card>> GetActiveCardsByUserIdAsync(long userId);

        Task<IEnumerable<Card>> GetAllActiveCardsAsync();

        Task<IEnumerable<Card>> GetCardsByTypeAsync(string type);

        Task<IEnumerable<Card>> GetCardsByCurrencyAsync(string currency);
    }
}
