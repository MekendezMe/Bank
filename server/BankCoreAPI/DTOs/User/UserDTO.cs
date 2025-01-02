using BankCoreAPI.Core.Models;
using BankCoreAPI.DTOs.Account;
using BankCoreAPI.DTOs.Card;

namespace BankCoreAPI.DTOs.User
{
    public class UserDTO
    {
        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string MobilePhone { get; set; } = string.Empty;

        public long RoleId { get; set; }

        public Role? Role { get; set; }

        public DateTime? ConfirmedAt { get; set; }

        public bool Deleted { get; set; }

        public ICollection<AccountDTO> Accounts { get; set; } = new List<AccountDTO>();

        public ICollection<CardDTO> Cards { get; set; } = new List<CardDTO>();
    }
}
