using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models.Cards;
using System.Data.Entity;

namespace BankCoreAPI.Core.Repositories
{
    public class CardTransactionRepository : GenericRepository<CardTransaction>, ICardTransactionRepository
    {
        ApplicationDbContext _context;
        public CardTransactionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CardTransaction>> GetCardTransactionsByCardReceiverIdAsync(long cardReceiverId)
        {
            return await _context.CardTransactions.Where(x => x.CardFromId == cardReceiverId).ToListAsync();
        }

        public async Task<IEnumerable<CardTransaction>> GetCardTransactionsByCardSenderIdAsync(long cardSenderId)
        {
            return await _context.CardTransactions.Where(x => x.CardToId == cardSenderId).ToListAsync();
        }

        public async Task<IEnumerable<CardTransaction>> GetCardTransactionsWithPositiveBalance()
        {
            return await _context.CardTransactions.Where(x => x.Balance > 0).ToListAsync();
        }
    }
}
