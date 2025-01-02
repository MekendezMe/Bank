using BankCoreAPI.Core.Models.Cards;

namespace BankCoreAPI.DTOs.Card
{
    public class CardTransactionDTO
    {
        public long CardFromId { get; set; }
        public CardDTO? CardFrom { get; set; }
        public long CardToId { get; set; }

        public CardDTO? CardTo { get; set; }

        public double Amount { get; set; }

        public double Balance { get; set; }

        public long CardTransactionTypeId { get; set; }

        public CardTransactionType? CardTransactionType { get; set; }
    }
}
