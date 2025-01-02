using BankCoreAPI.DTOs.Card;

namespace BankCoreAPI.DTOs.Account
{
    public class AccountOpenerDTO
    {
        public string Currency { get; set; } = string.Empty;

        public double InterestRate { get; set; }

        public double InterestAmount { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public CardDTO Card { get; set; } = null!;
        public double Amount { get; set; }
    }
}
