using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models;
using BankCoreAPI.Core.Models.Accounts;
using Microsoft.EntityFrameworkCore;

namespace BankCoreAPI.Core.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        ApplicationDbContext _context;
        public AccountRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Account?> GetAccountByNumberAsync(string number)
        {
            return await _context.Accounts.FirstOrDefaultAsync(x => x.Number == number);
        }

        public async Task<IEnumerable<Account>> GetAccountsByCurrencyAndUserIdAsync(string currency, long userId)
        {
            return await _context.Accounts.Where(x => x.Currency != null && x.Currency.Name == currency &&
            x.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Account>> GetAccountsByTypeAndUserIdAsync(string type, long userId)
        {
            return await _context.Accounts.Where(x => x.AccountType != null && x.AccountType.Name == type &&
            x.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Account>> GetAccountsByTypeAsync(string type)
        {
            return await _context.Accounts.Where(x => x.AccountType != null && x.AccountType.Name == type).ToListAsync();
        }

        public async Task<IEnumerable<Account>> GetAccountsByUserIdAsync(long userId)
        {
            return await _context.Accounts.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Account>> GetActiveAccountsByUserIdAsync(long userId)
        {
            return await _context.Accounts.Where(x => x.IsActive && x.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Account>> GetAllActiveAccountsAsync()
        {
            return await _context.Accounts.Where(x => x.IsActive).ToListAsync();
        }
    }
}
