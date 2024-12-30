using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Cards
{
    public class CardTransaction : BaseEntity
    {
        [Required]
        public long CardFromId { get; set; }

        public Card? CardFrom { get; set; }

        [Required]
        public long CardToId { get; set; }

        public Card? CardTo { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public double Balance { get; set; }

        [Required]
        public long CardTransactionTypeId { get; set; }

        public CardTransactionType? CardTransactionType { get; set; }
    }
}
