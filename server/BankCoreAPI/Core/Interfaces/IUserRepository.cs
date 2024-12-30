using BankCoreAPI.Core.Models;

namespace BankCoreAPI.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByMobilePhoneAsync(string mobilePhone);

        Task<IEnumerable<User>> GetAllDeletedUsersAsync();

        
    }
}
