using BankCoreAPI.DTOs.User;
using BankCoreAPI.Responses;

namespace BankCoreAPI.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> RegisterAsync(RegisterDTO user);

        Task<UserDTO> LoginAsync(LoginDTO user);

        Task<ActionResponse> ConfirmEmailByIdAsync(long id);

        Task<ActionResponse> ResetPasswordByEmailAsync(ResetPasswordDTO data);

        Task<ActionResponse> ChangePasswordByEmailAsync(string email);

        Task<UserDTO?> GetUserByIdAsync(long id);
    }
}
