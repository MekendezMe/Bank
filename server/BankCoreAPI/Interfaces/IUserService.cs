using BankCoreAPI.DTOs.User;
using BankCoreAPI.Responses;

namespace BankCoreAPI.Interfaces
{
    public interface IUserService
    {
        Task<ResponseType<UserDTO>> RegisterAsync(RegisterDTO user);

        Task<ResponseType<UserDTO>> LoginAsync(LoginDTO user);

        Task<ActionResponse> ConfirmEmailByIdAsync(long id);

        Task<ActionResponse> ResetPasswordByEmailAsync(ResetPasswordDTO data);

        Task<ActionResponse> ChangePasswordByEmailAsync(string email);
    }
}
