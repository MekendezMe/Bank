using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models;
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

        public Task<IEnumerable<User>> GetAllDeletedUsersAsync()
        {
            
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            
        }

        public Task<User> GetUserByMobilePhoneAsync(string mobilePhone)
        {

        }
    }
}
