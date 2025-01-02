namespace BankCoreAPI.DTOs.Account
{
    public class AccountTransferDTO
    {
        public string NumberReceiver { get; set; } = string.Empty;

        public double Amount { get; set; }

        public AccountDTO AccountSender { get; set; } = null!;
    }
}
