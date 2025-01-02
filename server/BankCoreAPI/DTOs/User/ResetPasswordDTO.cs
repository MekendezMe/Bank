namespace BankCoreAPI.DTOs.User
{
    public class ResetPasswordDTO
    {
        public string Email { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;
    }
}
