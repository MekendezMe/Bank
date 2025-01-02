using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace BankCoreAPI.Core.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllExistingUsersAsync()
        {
            return await _context.Users.Where(x => !x.Deleted).ToListAsync();
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User?> GetUserByMobilePhoneAsync(string mobilePhone)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.MobilePhone == mobilePhone);
        }


    }
}
