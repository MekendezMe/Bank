namespace BankCoreAPI.DTOs.Card
{
    public class CardTransferDTO
    {
        public string NumberReceiver { get; set; } = string.Empty;

        public double Amount { get; set; }

        public CardDTO CardSender { get; set; } = null!;
    }
}
