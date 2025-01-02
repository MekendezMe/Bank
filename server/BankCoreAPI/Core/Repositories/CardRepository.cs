using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models;
using BankCoreAPI.Core.Models.Cards;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BankCoreAPI.Core.Repositories
{
    public class CardRepository : GenericRepository<Card>, ICardRepository
    {
        ApplicationDbContext _context;
        public CardRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Card>> GetActiveCardsByUserIdAsync(long userId)
        {
            return await _context.Cards.Where(x => x.IsActive && x.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Card>> GetAllActiveCardsAsync()
        {
            return await _context.Cards.Where(x => x.IsActive).ToListAsync();
        }

        public async Task<Card?> GetCardByNumberAsync(string number)
        {
            return await _context.Cards.FirstOrDefaultAsync(x => x.Number == number);
        }

        public async Task<IEnumerable<Card>> GetCardsByCurrencyAndUserIdAsync(string currency, long userId)
        {
            return await _context.Cards
               .Where(x => x.Currency != null && x.Currency.Name == currency && x.UserId == userId)
               .ToListAsync();
        }

        public async Task<IEnumerable<Card>> GetCardsByTypeAndUserIdAsync(string type, long userId)
        {
            return await _context.Cards
               .Where(x => x.CardType != null && x.CardType.Name == type && x.UserId == userId)
               .ToListAsync();
        }

        public async Task<IEnumerable<Card>> GetCardsByUserIdAsync(long userId)
        {
            return await _context.Cards.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
