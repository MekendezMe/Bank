using BankCoreAPI.Core.Models;

namespace BankCoreAPI.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByMobilePhoneAsync(string mobilePhone);

        Task<IEnumerable<User>> GetAllExistingUsersAsync();

        Task<bool> ConfirmEmailByIdAsync(long id);
    }
}
