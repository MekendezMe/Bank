namespace BankCoreAPI.Responses
{
    public class DepositResponse
    {
        public bool Success { get; set; }

        public string? Message { get; set; }

        public double newBalance { get; set; }
    }
}
