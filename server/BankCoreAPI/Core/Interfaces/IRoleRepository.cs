using BankCoreAPI.Core.Models;

namespace BankCoreAPI.Core.Interfaces
{
    public interface IRoleRepository
    {
        Task<Role?> GetRoleByNameAsync(string name);
    }
}
