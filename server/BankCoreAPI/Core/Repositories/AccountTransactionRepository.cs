using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models.Accounts;
using System.Data.Entity;

namespace BankCoreAPI.Core.Repositories
{
    public class AccountTransactionRepository : GenericRepository<AccountTransaction>, IAccountTransactionRepository
    {
        ApplicationDbContext _context;
        public AccountTransactionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AccountTransaction>> GetAccountTransactionsByAccountReceiverIdAsync(long accountReceiverId)
        {
            return await _context.AccountTransactions.Where(x => x.AccountFromId == accountReceiverId).ToListAsync();
        }

        public async Task<IEnumerable<AccountTransaction>> GetAccountTransactionsByAccountSenderIdAsync(long accountSenderId)
        {
            return await _context.AccountTransactions.Where(x => x.AccountToId == accountSenderId).ToListAsync();
        }

        public async Task<IEnumerable<AccountTransaction>> GetAccountTransactionsWithPositiveBalance()
        {
            return await _context.AccountTransactions.Where(x => x.Balance > 0).ToListAsync();
        }
    }
}
