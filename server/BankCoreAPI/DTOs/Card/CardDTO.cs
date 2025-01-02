using BankCoreAPI.Core.Models.Cards;
using BankCoreAPI.DTOs.User;

namespace BankCoreAPI.DTOs.Card
{
    public class CardDTO
    {
        public long UserId { get; set; }
        public UserDTO? User { get; set; }

        public long CardTypeId { get; set; }

        public CardType? CardType { get; set; }

        public string Number { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public double Balance { get; set; }

        public string Currency { get; set; } = string.Empty;

        public DateTime? ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsActivate { get; set; }

        public DateTime? BlockedAt { get; set; }

        public ICollection<CardTransactionDTO> CardFromTransactions { get; set; }
            = new List<CardTransactionDTO>();
        public ICollection<CardTransactionDTO> CardToTransactions { get; set; }
            = new List<CardTransactionDTO>();


    }
}
