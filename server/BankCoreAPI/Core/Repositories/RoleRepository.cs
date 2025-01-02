using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models;
using System.Data.Entity;

namespace BankCoreAPI.Core.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Role?> GetRoleByNameAsync(string name)
        {
            return await _context.Roles.FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
